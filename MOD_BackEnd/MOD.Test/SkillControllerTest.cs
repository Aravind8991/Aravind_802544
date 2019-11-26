using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MOD_TechnologyService.Repositories;
using MOD_TechnologyService.Controllers;
using MOD_TechnologyService.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MOD.Test
{
    public class SkillControllerTest
    {
        private readonly Mock<ISkillRepository> _repo;
        private readonly SkillController _controller;
        public SkillControllerTest()
        {
            _repo = new Mock<ISkillRepository>();
            _controller = new SkillController(_repo.Object);
        }

        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetTechnology()).Returns(GetSkills());
            var result = _controller.Get() as List<Skills>;
            Assert.Equal(3, result.Count);
        }
        private List<Skills> GetSkills()
        {
            return new List<Skills>()
    {
        new Skills(){SkillId="S001",SkillName="java"},
        new Skills(){SkillId="S002",SkillName="mean"},
        new Skills(){SkillId="S003",SkillName="dotnet"}
    };
        }

        //public void GetById()
        //{
        //    //arrange
        //    _repo.Setup(m=>m.GetTechnologyById)("Java")).Returns(GetSkills()[0]);
        //    //act
        //    var result = _controller.Get("Java") as Skill;
        //    //assert
        //    Assert.NotNull(result);
        //    Assert.Equal("java", result.SkillName);
        //}
        [Fact]
        public void post()
        {
            var item = GetSkills()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void put()
        {
            var item = GetSkills()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.Delete(It.IsAny<string>()));
            var result = _controller.Delete("S001") as OkResult;
            Assert.NotNull(result);
        }
    }
}