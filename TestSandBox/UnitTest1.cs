using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using ToDoApi;

namespace Tests
{
    public class Tests
    {
        BookController _controller;
        
        [SetUp]
        public void Setup()
        {
            _controller = new BookController();
        }

        [TestCase]
        public void CanCreateBookController()
        {
          
            Assert.AreNotEqual(null, _controller);
        }

       

        [TestCase]
        public void IfBookCollectionThenReturn200()
        {
            _controller.Post(new Book { Count = 2, Title = "Hellow" });
            var result = _controller.Get();
            Assert.IsInstanceOf<OkResult>(result);
         
          
        }
        [TestCase]
        public void IfBookCollectionIsEmptyThenReturn204()
        {
            var result = _controller.Get();
            Assert.IsInstanceOf<NoContentResult>(result);
           
        }

        [TestCase]
        public void Retrun201WhenBookCreated()
        {
           
         var result=   _controller.Post(new Book { Count = 2, Title = "Hellow" });
            Assert.IsInstanceOf<CreatedResult>(result);
        }

        [TestCase]
        public void RetrunProperUrlWhenBookCreated()
        {

            var result = _controller.Post(new Book { Count = 2, Title = "Hellow" }) as CreatedResult;
           
        }
    }
}