using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using skills;
using Xunit;

namespace skillstest
{
    public class SkillsRepositoryTests
    {
        private SkillsRepository repo;

        public SkillsRepositoryTests(){
            repo = new SkillsRepository();
        }

        
        [Fact]
        public void AddTest()
        {
            var sk = new Skill{ID=4, Name="Azure Dev"};
            repo.AddSkill(sk);
            Assert.True(repo.Items == 4);
        }
    }
}
