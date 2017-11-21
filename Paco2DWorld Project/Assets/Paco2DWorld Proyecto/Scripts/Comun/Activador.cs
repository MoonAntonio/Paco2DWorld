//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Activador.cs (00/00/0000)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com								        \\
// Descripcion:																	\\
// Fecha Mod:		00/00/0000													\\
// Ultima Mod:																	\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System;
#endregion

namespace MoonAntonio
{
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