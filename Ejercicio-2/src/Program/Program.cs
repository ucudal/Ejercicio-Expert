using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            
            string appointmentResult3 = AppointmentService.CreateAppointment("Ralf Manson", "44", "5555-555-555", DateTime.Now, "Queen Street", "aa");
            Console.WriteLine(appointmentResult3);

            //probando que la cita no quede programada ya que se repite el id 
            string appointmentResult4 = AppointmentService.CreateAppointment("Ralf Manson", "986782342", "5555-555-555", DateTime.Now, "Queen Street", "aa");
            Console.WriteLine(appointmentResult4);
        }
    }
}
