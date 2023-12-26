using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using System;
using ADMIN;

public class UDPClient
{

    private Socket _socket;
    private EndPoint _ep;

    public static int UDP_PORT = 5432;
    public static bool UDP_ENABLED = false;

    private byte[] _buffer_recv;
    private ArraySegment<byte> _buffer_recv_segment;

    public bool Initialize(IPAddress address)
    {
        if (UDP_PORT < 1 || UDP_PORT > 65535) return false;
        try
        {
            _buffer_recv = new byte[4096];
            _buffer_recv_segment = new ArraySegment<byte>(_buffer_recv);

            _ep = new IPEndPoint(address, UDP_PORT);

            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, true);
            return true;
        }
        catch (Exception ex) { Log.AddException(ex); return false; }
    }


    public async Task Send(byte[] data)
    {
        var s = new ArraySegment<byte>(data);
        await _socket.SendToAsync(s, SocketFlags.None, _ep);
    }
}
