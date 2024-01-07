using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Text;
using Omnirig_CAT;
using System.Windows.Forms;
using ADMIN;

public class UDPServer
{
    

    private Socket _socket;
    private EndPoint _ep;
    private Form1 _f;
    private Delegate _d;
    private byte[] _buffer_recv;
    private ArraySegment<byte> _buffer_recv_segment;

    public void Initialize(Form1 f, Delegate d,int UDP_PORT)
    {
        _f = f;
        _d = d;
        _buffer_recv = new byte[4096];
        _buffer_recv_segment = new ArraySegment<byte>(_buffer_recv);

        _ep = new IPEndPoint(IPAddress.Any, UDP_PORT);

        _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, true);
        _socket.Bind(_ep);
    }

    public void StartMessageLoop()
    {
        _ = Task.Run(async () =>
        {
            SocketReceiveMessageFromResult res;
            while (true)
            {
                try
                {
                    res = await _socket.ReceiveMessageFromAsync(_buffer_recv_segment, SocketFlags.None, _ep);
                    // await SendTo(res.RemoteEndPoint, Encoding.UTF8.GetBytes("Hello back!"));
                    //  Application.Exit();
                    byte[] b = new byte[res.ReceivedBytes];
                    for (int i = 0; i < res.ReceivedBytes; i++) b[i] = _buffer_recv[i];
                    _f.BeginInvoke(_d, new object[] { PROCKI.bytesToString(b) });                
                }
                catch (Exception ex)
                {
                    Log.AddException(ex);
                }
            }
        });
    }

    public async Task SendTo(EndPoint recipient, byte[] data)
    {
        var s = new ArraySegment<byte>(data);
        await _socket.SendToAsync(s, SocketFlags.None, recipient);
    }
}
