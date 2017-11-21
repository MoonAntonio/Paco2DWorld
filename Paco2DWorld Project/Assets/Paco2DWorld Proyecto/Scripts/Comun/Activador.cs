//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Activador.cs (21/11/2017)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Activador de eventos										\\
// Fecha Mod:		21/11/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Activador de eventos</para>
	/// </summary>
	public class Activador : MonoBehaviour
	{
		#region Metodos
		/// <summary>
		/// <para>Cuando se entra a una collision.</para>
		/// </summary>
		/// <param name="collision"></param>
		private void OnCollisionEnter2D(Collision2D collision)// Cuando se entra a una collision
		{
			this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
		}
		#endregion
	}
}