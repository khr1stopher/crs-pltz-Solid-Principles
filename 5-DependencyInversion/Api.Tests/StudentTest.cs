using Xunit;
using DependencyInversion.Controllers;
using System.Collections.ObjectModel; // for ObjectModel
using Moq;
using DependencyInversion;

namespace Api.Tests;


public class StudentTest
{


    // [Fact]
    // public void GetStudent()
    // {
    //     var studentController = new StudentController();

    //     var resultGetStudents = studentController.Get();

    //     Assert.NotNull(resultGetStudents);
    //     Assert.Equal(3, resultGetStudents.Count());
    // }


    [Fact]
    public void GetStudent()
    {
        var logbookMock = new Mock<Logbook>();
        var studentRepositoryMock = new Mock<StudentRepository>();
        studentRepositoryMock.Setup(p => p.GetAll()).Returns(new List<Student>(){
            new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }),
            new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }),
            new Student(3, "José Molina", new List<double>() { 2, 3 })
        });

        var studentController = new StudentController(studentRepositoryMock.Object, logbookMock.Object);

        var resultGetStudents = studentController.Get();

        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }

}