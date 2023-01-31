//
//Id de estudiante: 181091673
//Nombre y Apellidos de estudiante: Juan Carlos Serrano Rodríguez
//Nombre de la Universidad: EDP University
//Código y título del curso: ITP-4385 - Programación Orientada a Objetos II
//Nombre de la aplicacion: RegistroClientes
//Nombre del programa: Person.cs
//Fecha de creación: 9-Septiembre-2021
//Describción general: Programa que permite gestionar los datos (variables atributos)
//					   y metodos (funciones) de los objetos de la clase Persona.
//
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCliente
{
	class Person
	{
		private string name = "";
		private string lastName = "";
		private char gender = 'M';  //M = Male   F = Female
		private string dob = "";
		private int yearsOld = 0;

		public Person()
		{

			name = "Default";
			lastName = "Default";
			gender = 'M';
			dob = "11/09/1991 12:01 AM";
			yearsOld = 0;
		}
		public Person(string name, string lastName, char gender, string dob)
		{
			this.name = name;
			this.lastName = lastName;
			this.gender = gender;
			this.dob = dob;
			yearsOld = 0;

		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}
		public char Gender
		{
			get
			{
				return gender;
			}
			set
			{
				gender = value;
			}
		}

		public string DOB
		{
			get
			{
				return dob;
			}
			set
			{
				dob = value;
			}
		}

		public int YearsOld
		{
			get
			{
				var today = DateTime.Today;
				var dob = Convert.ToDateTime(this.DOB);

				this.yearsOld = today.Year - dob.Year;

				return yearsOld;
			}
			set
			{
				yearsOld = value;
			}
		}

		public override string ToString()
		{
			return "Person: Name = " + this.name + "Person: Last Name = "
				+ this.lastName + "Person: Gender = " + this.gender
				+ "Person: DOB = " + this.dob + ", Person: YearsOld = " + this.yearsOld;

		}

		public string ToString1()
		{
			return "Person: Name = " + this.name + "Person: last Name = "
				+ this.lastName + "Person: Gender = " + this.gender
				+ "Person: DOB = " + this.dob + ", Person: YearsOld = " + this.yearsOld;
		}
	}
}



