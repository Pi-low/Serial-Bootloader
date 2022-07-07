using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NelloCom
{
	internal class messageHex
	{
		private byte m_type;
		private short m_adress;
		private byte m_size;
		private byte[] m_data;
		private byte m_crc;
		public messageHex( string line)
		{
			char[] data = line.ToCharArray();
			m_type = (byte)(Convert.ToByte(data[2]-48)  + ((Convert.ToByte(data[1]-48) << 4)));
			m_adress = (byte)(Convert.ToByte(data[6] - 48) + ((Convert.ToByte(data[5] - 48) << 4)) + ((Convert.ToByte(data[4] - 48) << 8)) + ((Convert.ToByte(data[3] - 48) << 12)));
			m_size = (byte)(Convert.ToByte(data[8] - 48) + ((Convert.ToByte(data[7] - 48) << 4)));
			if (m_size > 1)
			{
				m_data = new byte[m_size / 2];
				for (byte i = 0; i < m_size / 2; i++)
				{
					m_data[i] = (byte)(Convert.ToByte(data[10 + i * 2] - 48) + ((Convert.ToByte(data[9 + i * 2] - 48) << 4)));
				}
				m_crc = (byte)(Convert.ToByte(data[10 + m_size] - 48) + ((Convert.ToByte(data[9 + m_size] - 48) << 4)));
			}
			else
			{
				m_crc = (byte)(Convert.ToByte(data[10] - 48) + ((Convert.ToByte(data[9] - 48) << 4)));
			}
		}
	}
}
