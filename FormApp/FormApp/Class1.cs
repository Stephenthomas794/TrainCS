using AGaugeApp;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;

namespace Class1App
{
    internal class Class1
    {
		private int speedValue;
		private bool modeValue1;
		private bool modeValue2;
		private bool modeValue3;

		public Class1()
        {
			this.speedValue = 0;
			this.modeValue1 = true;
			this.modeValue2 = false;
			this.modeValue3 = true;

		}

		public int getSpeedValue()
		{
			return this.speedValue;
		}

		public void changeSpeed(int speedValue)
		{
			this.speedValue = speedValue;
			
			getSpeedValue();
		}


	}
}




/*
 

			public bool getMode1()
		{
			return this.modeValue1;
		}

		public bool getMode2()
		{
			return this.modeValue2;
		}

		public bool getMode3()
		{
			return this.modeValue3;
		}

		public void changeMode(bool mode1, bool mode2, bool mode3)
		{
			this.modeValue1 = mode1;
			getMode1();

			this.modeValue2 = mode2;
			getMode2();

			this.modeValue3 = mode3;
			getMode3();

		}
		}
	 
	 
	 */
