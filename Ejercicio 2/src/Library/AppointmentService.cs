using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static Boolean isValid = true;
    
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            //Boolean isValid = true;
        
            Patient pat = new Patient(name, id, phoneNumber, stringBuilder);
            Appointment cita = new Appointment(appoinmentPlace, stringBuilder);
            Doctor doc = new Doctor(doctorName, stringBuilder);


            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }
            return stringBuilder.ToString();
        }
    }

    public class Patient{
            public Patient(String name, String id, String phoneNumber, StringBuilder stringBuilder){
                if (string.IsNullOrEmpty(name))
                {
                    stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                    AppointmentService.isValid = false;

                }

                if (string.IsNullOrEmpty(id))
                {
                    stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                    AppointmentService.isValid = false;
                }

                if (string.IsNullOrEmpty(phoneNumber))
                {
                    stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                    AppointmentService.isValid = false;
                }
            }
    }

    public class Appointment{
            public Appointment(String appoinmentPlace, StringBuilder stringBuilder){
                if  (string.IsNullOrEmpty(appoinmentPlace)){
                    stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                    AppointmentService.isValid = false;
                }
            }
    }

    public class Doctor{
            public Doctor(String doctorName, StringBuilder stringBuilder){
                if (string.IsNullOrEmpty(doctorName))
                {
                    stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                    AppointmentService.isValid = false;
                }
            }
    }
}

/*De acuerdo los patrones y principio considero que en el código se derberia de realizar una clase que contenga los datos 
de los pacientes, otra del doctor, otra que se encargue de la información de la appointment, y una última clase  "AppointmentService" que va a
tener la información necesaria para poder cumplir con la responsabilidad.*/