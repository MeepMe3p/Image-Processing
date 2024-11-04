using System;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;

namespace WebCamLib
{
    public class DeviceManager
    {
	//	[DllImport("inpout32.dll", EntryPoint="Out32")]
	//	public static extern void Output(int adress, int value);
		
	//	[DllImport("inpout32.dll", EntryPoint="Inp32")]
	//	public static extern int Input(int adress);
		
        [DllImport("avicap32.dll")]
        // wDriverIndex = index of the capture driver from 0-9
        // lspzname = basically null terminated string for the name
        // cbname = length in byetes of buffer pointed to lpszname
        //lpszver =same thing sa name but kani kay description
        // cbver = length of ver
        protected static extern bool capGetDriverDescriptionA(short wDriverIndex,
            [MarshalAs(UnmanagedType.VBByRefStr)]ref String lpszName,
           int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszVer, int cbVer);

        static ArrayList devices = new ArrayList();

        public static Device[] GetAllDevices()
        {
            String dName = "".PadRight(100); // padding raman ni sha murag pina html 100 places to right
            String dVersion = "".PadRight(100);

            for (short i = 0; i < 10; i++)
            {
                // creates a new device and names it then places it sa array 
                if (capGetDriverDescriptionA(i, ref dName, 100, ref dVersion, 100))
                {
                    Device d = new Device(i); // naghimog device where i is the index -> proceed to init
                    d.Name = dName.Trim();
                    d.Version = dVersion.Trim();

                    devices.Add(d);                    
                }
            }

            return (Device[])devices.ToArray(typeof(Device));
        }

        public static Device GetDevice(int deviceIndex)
        {
            return (Device)devices[deviceIndex];
        }
    }
}
