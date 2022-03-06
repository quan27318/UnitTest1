using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UnitTest.Controllers;
using UnitTest.Models;
using UnitTest.Service;

namespace UnitTestPro;

public class HomeControllerTests
{
    private Mock<ILogger<HomeController>> _loggerMock;
    private Mock<IPerson> _personMock;
    static List<Person> _people = new List<Person>(){
            new Person{
                StudentID = 1,
                StudentName="Quan",
                Age="22",
                Address="Ha Noi"
            },
            new Person{
                StudentID = 2,
                StudentName="Quan2",
                Age="22",
                Address="Ha Noi"
            },
            new Person{
                StudentID = 3,
                StudentName="Quan3",
                Age="22",
                Address="Ha Noi"
            }
    };
    [SetUp]
    public void Setup()
    {
        _loggerMock = new Mock<ILogger<HomeController>>();
        _personMock = new Mock<IPerson>();

        //SetUP
        _personMock.Setup(x=>x.GetAll()).Returns(_people);
    }

    [Test]
    public void Test1()
    {
        

        //Arrage
        var controller = new HomeController(_loggerMock.Object, _personMock.Object);

        //Act
        var result = controller.Index();
        
        //Assert
        Assert.IsInstanceOf<ViewResult>(result, "Test");
    }
}