using System;
using System.Collections.Generic;
using System.Text;
using DirectShowLib;
using System.Runtime.InteropServices;

namespace CAT_CAMERA
{
    public class AudioSource : Source
    {

        // --------------------- Private/Internal properties -------------------------

        internal IPin Pin;			// audio mixer interface (COM object)



        // -------------------- Constructors/Destructors ----------------------

        /// <summary> Constructor. This class cannot be created directly. </summary>
        internal AudioSource(IPin pin)
        {
            if ((pin as IAMAudioInputMixer) == null)
                throw new NotSupportedException("The input pin does not support the IAMAudioInputMixer interface");
            this.Pin = pin;
            this.name = getName(pin);
        }



        // ----------------------- Public properties -------------------------

        /// <summary> Enable or disable this source. For audio sources it is 
        /// usually possible to enable several sources. When setting Enabled=true,
        /// set Enabled=false on all other audio sources. </summary>
        public override bool Enabled
        {
            get
            {
                IAMAudioInputMixer mix = (IAMAudioInputMixer)Pin;
                bool e;
                mix.get_Enable(out e);
                return (e);
            }

            set
            {
                IAMAudioInputMixer mix = (IAMAudioInputMixer)Pin;
                mix.put_Enable(value);
            }

        }



        // --------------------------- Private methods ----------------------------

        /// <summary> Retrieve the friendly name of a connectorType. </summary>
        private string getName(IPin pin)
        {
            string s = "Unknown pin";
            PinInfo pinInfo = new PinInfo();

            // Direction matches, so add pin name to listbox
            int hr = pin.QueryPinInfo(out pinInfo);
            if (hr == 0)
            {
                s = pinInfo.name + "";
            }
            else
                Marshal.ThrowExceptionForHR(hr);

            // The pininfo structure contains a reference to an IBaseFilter,
            // so you must release its reference to prevent resource a leak.
            if (pinInfo.filter != null)
                Marshal.ReleaseComObject(pinInfo.filter); pinInfo.filter = null;

            return (s);
        }

        // -------------------- IDisposable -----------------------

        /// <summary> Release unmanaged resources. </summary>
        public override void Dispose()
        {
            if (Pin != null)
                Marshal.ReleaseComObject(Pin);
            Pin = null;
            base.Dispose();
        }
    }
}

