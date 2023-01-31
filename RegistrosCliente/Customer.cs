//
//Id de estudiante: 181091673
//Nombre y Apellidos de estudiante: Juan Carlos Serrano Rodríguez
//Nombre de la Universidad: EDP University
//Código y título del curso: ITP-4385 - Programación Orientada a Objetos II
//Nombre de la aplicacion: RegistroClientes
//Nombre del programa: Person.cs
//Fecha de creación: 9-Septiembre-2021
//Describción general: Programa que permite gestionar los datos (variables atributos)
//					   y metodos (funciones) de los objetos de la clase Cliente.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroCliente
{
	class Customer : Person
	{
		private int id;
		private String street;
		private String city;
		private String state;
		private String zipCode;
		private String phone;
		private Boolean inactive;
		private String email;
		private String profession;
		private String businessType;
		private String photo;
		private String notes;


		public Customer()     //Default contructor.
		{
			id = -1;
			street = "Default";
			city = "Default";
			state = "PR";
			phone = ""; //"(999) 999-9999";
			zipCode = "";
			inactive = false;
			email = "";
			profession = "";
			businessType = "";
			photo = "";
			notes = "";
			this.Name = "Default";
			this.LastName = "Default";
			this.Gender = 'M';
			this.DOB = "11/09/1991 12:01 AM";
			this.YearsOld = 0;
		}
		public Customer(int id, string name, string lastName, string street, string city,
			string state, string zipCode, string phone, Boolean inactive, char gender, string dob,
			string email, string profession, string businessType, string photo, string notes)
		{
			this.id = id;
			this.Name = name;
			this.LastName = lastName;
			this.street = street;
			this.city = city;
			this.state = state;
			this.zipCode = zipCode;
			this.phone = phone;
			this.inactive = inactive;
			this.Gender = gender;
			this.DOB = dob;
			this.email = email;
			this.profession = profession;
			this.businessType = businessType;
			this.photo = photo;
			this.notes = notes;
		}

		public int ID
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}
		public string Street
		{
			get
			{
				return street;
			}
			set
			{
				street = value;
			}
		}
		public string City
		{
			get
			{
				return city;
			}
			set
			{
				city = value;
			}
		}
		public string State
		{
			get
			{
				return state;
			}
			set
			{
				state = value;
			}
		}
		public string ZipCode
		{
			get
			{
				return zipCode;
			}
			set
			{
				zipCode = value;
			}
		}
		public string Phone
		{
			get
			{
				return phone;
			}
			set
			{
				phone = value;
			}
		}
		public Boolean Inactive
		{
			get
			{
				return inactive;
			}
			set
			{
				inactive = value;
			}
		}
		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}
		public string Profession
		{
			get
			{
				return profession;
			}
			set
			{
				profession = value;
			}
		}
		public string BusinessType
		{
			get
			{
				return businessType;
			}
			set
			{
				businessType = value;
			}
		}
		public string Photo
		{
			get
			{
				return photo;
			}
			set
			{
				photo = value;
			}
		}
		public string Notes
		{
			get
			{
				return notes;
			}
			set
			{
				notes = value;
			}
		}

		public override string ToString()
		{
			String output = "ID = " + this.id + "\n";
			output = output + "Name = " + this.Name + "\n";
			output = output + "last Name = " + this.LastName + "\n";
			output = output + "Street = " + this.street + "\n";
			output = output + "City = " + this.city + "\n";
			output = output + "State = " + this.state + "\n";
			output = output + "ZipCode = " + this.zipCode + "\n";
			output = output + "Phone = " + this.phone + "\n";
			output = output + "Inactive = " + this.inactive + "\n";
			output = output + "Gender = " + this.Gender + "\n";
			output = output + "DOB = " + this.DOB + "\n";
			output = output + "Email = " + this.email + "\n";
			output = output + "Profession = " + this.profession + "\n";
			output = output + "BusinessType = " + this.businessType + "\n";
			output = output + "Photo = " + this.photo + "\n";
			output = output + "Notes = " + this.notes + "\n" + "\n";

			return output;

		}
	}

}
