
using System;

namespace MDPI_TP2
{
	public interface Iterator
	{
		void primero();
        void siguiente();
        bool fin();
        Icomparable actual();
	}
}
