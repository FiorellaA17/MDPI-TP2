
using System;

namespace MDPI_TP2
{
	public interface Icoleccionable : Iterable
	{
		int cuantos(); 
		Icomparable minimo(); 
		Icomparable maximo();
		void agregar (Icomparable c);
		bool contiene (Icomparable c); 
	}
}
