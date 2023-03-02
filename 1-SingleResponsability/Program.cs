using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");