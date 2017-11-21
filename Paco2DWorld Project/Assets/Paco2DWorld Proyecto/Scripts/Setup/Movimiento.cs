//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Movimiento.cs (21/11/2017)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Movimiento del personaje									\\
// Fecha Mod:		21/11/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	public class Movimiento : MonoBehaviour 
	{
		#region Variables
		/// <summary>
		/// <para>Velocidad</para>
		/// </summary>
		public float velX = 0.1f;						// Velocidad
		/// <summary>
		/// <para>Movimiento</para>
		/// </summary>
		public float movX = 0.0f;						// Movimiento
		/// <summary>
		/// <para>Posicion actual</para>
		/// </summary>
		public float pos = 0.0f;                        // Posicion actual
		/// <summary>
		/// <para>Fuerza del salto.</para>
		/// </summary>
		public float fuerzaSalto = 100f;				// Fuerza del salto
		/// <summary>
		/// <para>Determina si esta en el suelo.</para>
		/// </summary>
		public bool isSuelo = true;                     // Determina si esta en el suelo
		/// <summary>
		/// <para>Sonido del salto.</para>
		/// </summary>
		public AudioSource sonidoSalto;					// Sonido del salto
		#endregion

		#region Actualizadores
		/// <summary>
		/// <para>Actualizacion de fisicas.</para>
		/// </summary>
		private void FixedUpdate()// Actualizacion de fisicas
		{
			float inputX = Input.GetAxis("Horizontal");

			// Mov horizontal
			if (inputX > 0)
			{
				movX = this.transform.position.x + (inputX * velX);
				this.transform.position = new Vector3(movX, this.transform.position.y, 0);
				this.transform.localScale = new Vector3(1, 1, 1);
				movX = pos;
			}

			if (inputX < 0)
			{
				movX = this.transform.position.x + (inputX * velX);
				this.transform.position = new Vector3(movX, this.transform.position.y, 0);
				this.transform.localScale = new Vector3(-1, 1, 1);
				movX = pos;
			}

			// Salto
			if (Input.GetKeyDown(KeyCode.Space) && isSuelo == true)
			{
				isSuelo = false;
				sonidoSalto.Stop();
				sonidoSalto.Play();
				this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,fuerzaSalto));
			}
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Cuando se entra a una collision.</para>
		/// </summary>
		/// <param name="collision"></param>
		private void OnCollisionEnter2D(Collision2D collision)// Cuando se entra a una collision
		{
			isSuelo = true;
		}
		#endregion
	}
}