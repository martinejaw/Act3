using System;
using System.Linq;
using EFGetStarted.Entidades;
using EFGetStarted.Repositorios;

namespace EFGetStarted
{
    class Programa
    {
        static void Main()
        {

            using (var db = new ContextoHospital())
            {
                IUnitOfWork uow = new UnitOfWork();

                IPruebaService pruebaService = new PruebaService(uow);

                var prueba = new Prueba();

                pruebaService.Create(prueba);

            }

            /*var paciente1 = new Paciente { dni = 41000001 ,
                                           nombre = "Martin",
                                            apellido = "Yaoming"};
            var paciente2 = new Paciente { dni = 41000002 ,
                                            nombre = "Juan",
                                            apellido = "Bo"};
            var paciente3 = new Paciente { dni = 41000003 ,
                                            nombre = "Jazmin",
                                            apellido = "Flores"};


            var medico1 = new Medico { matricula = 10001, nombre = "Ezequiel", apellido = "Del Peru"};
            var medico2 = new Medico { matricula = 10002, nombre = "Hernan", apellido = "Troncoso"};

            var caso1 = new Caso { estado = "En prueba", medico = medico1, paciente = paciente1};
            var caso2 = new Caso { estado = "Sospechoso", medico = medico1, paciente = paciente2};
            var caso3 = new Caso { estado = "Saludable", medico = medico2, paciente = paciente3};

            var consulta1 = new Consulta { descripcionSintomas = "catarro, diarrea" };
            var consulta2 = new Consulta { descripcionSintomas = "estornudos, fiebre" };
            var consulta3 = new Consulta { descripcionSintomas = "estornudos, fiebre" };

            medico1.consultas.Add(consulta1);
            medico1.consultas.Add(consulta2);
            medico2.consultas.Add(consulta3);
            paciente1.consultas.Add(consulta1);
            paciente2.consultas.Add(consulta2);
            paciente3.consultas.Add(consulta3);


            using (var db = new ContextoHospital())
            {

                //Insercion de en la base de datos, esto solo debe hacerse una vez
                db.Add(caso1);
                db.Add(caso2);
                db.Add(caso3);
                db.Add(paciente1);
                db.Add(paciente2);
                db.Add(paciente3);
                db.Add(medico1);
                db.Add(medico2);
                db.Add(consulta1);
                db.Add(consulta2);
                db.Add(consulta3);
                db.SaveChanges();


                Console.WriteLine("Listando todos los casos en la BBDD");
                var casos = db.Casos
                    .OrderBy(c => c.CasoId)
                    .ToList();
                
                foreach (Caso caso in casos){
                    Console.WriteLine("Numero de caso: ");
                    Console.WriteLine(caso.CasoId);
                    Console.WriteLine("Paciente del caso: ");
                    Console.WriteLine(caso.pacientedni);
                    Console.WriteLine("Medico encargado: ");
                    Console.WriteLine(caso.medicomatricula);
                    Console.WriteLine("////////////////////////////");
                }
                
                Console.WriteLine("////////////////////////////");
                Console.WriteLine("----------------------------");
                Console.WriteLine("////////////////////////////");
            

                Console.WriteLine("Leyendo las consultas asignadas al medico1");
                var consultas = db.Consultas
                    .Where(c => c.medicomatricula == medico1.matricula)
                    .OrderBy(c => c.ConsultaId)
                    .ToList();

                foreach (Consulta consulta in consultas){
                    Console.WriteLine("Numero de consulta: ");
                    Console.WriteLine(consulta.ConsultaId);
                    Console.WriteLine("Paciente del caso: ");
                    Console.WriteLine(consulta.pacientedni);
                    Console.WriteLine("Medico encargado: ");
                    Console.WriteLine(consulta.medicomatricula);
                    Console.WriteLine("////////////////////////////");
                }



                //Ejemplo actualizacion
                Console.WriteLine("Medico1 de licencia, se asigna al medico2 a los casos del medico1");
                var casosAsignar = db.Casos
                    .Where(c => c.medicomatricula == 10001)
                    .ToList();

                foreach (Caso casoa in casosAsignar){
                    Console.WriteLine("Asignando caso {0} a medico2",casoa.CasoId);
                    casoa.medicomatricula = 10002;
                    db.SaveChanges();
                }
            }*/    
        }
    }
}