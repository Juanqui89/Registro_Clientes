//
//Id de estudiante: 181091673
//Nombre y Apellidos de estudiante: Juan Carlos Serrano Rodríguez
//Nombre de la Universidad: EDP University
//Código y título del curso: ITP-4385 - Programación Orientada a Objetos II
//Nombre de la aplicacion: RegistroClientes
//Nombre del programa: Person.cs
//Fecha de creación: 9-Septiembre-2021
//Describción general: Programa que permite gestionar los datos (variables atributos)
//					   y metodos (funciones) de los objetos de la clase Cliente en formato JSON.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroCliente
{
    class CustomerJSON
    {

        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public char gender { get; set; }
        public string dob { get; set; }
        public int yearsOld { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string phone { get; set; }
        public string inactive { get; set; }
        public string email { get; set; }
        public string profession { get; set; }
        public string businessType { get; set; }
        public string photo { get; set; }
        public string notes { get; set; }

        public CustomerJSON()
        {

        }

        public CustomerJSON(int id, string name, string lastName, char gender, string dob, int yearsOld,
            string street, string city, string state, string zipCode, string phone, string inactive,
            string email, string profession, string businessType, string photo, string notes)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.street = street;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phone = phone;
            this.inactive = inactive;
            this.gender = gender;
            this.dob = dob;
            this.email = email;
            this.profession = profession;
            this.businessType = businessType;
            this.photo = photo;
            this.notes = notes;
        }



        public override string ToString()
        {
            String output = "Id = " + this.id + "\n";
            output = output + "Name = " + this.name + "\n";
            output = output + "Last Name = " + this.lastName + "\n";
            output = output + "Street = " + this.street + "\n";
            output = output + "City = " + this.city + "\n";
            output = output + "State = " + this.state + "\n";
            output = output + "ZipCode = " + this.zipCode + "\n";
            output = output + "Phone = " + this.phone + "\n";
            output = output + "Inactive = " + this.inactive + "\n";
            output = output + "Gender = " + this.gender + "\n";
            output = output + "DOB = " + this.dob + "\n";
            output = output + "Email = " + this.email + "\n";
            output = output + "Profession = " + this.profession + "\n";
            output = output + "BusinessType = " + this.businessType + "\n";
            output = output + "Photo = " + this.photo + "\n";
            output = output + "Notes = " + this.notes + "\n" + "\n";

            return output;

        }
    }

}





