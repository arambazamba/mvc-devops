
using System.Collections;
using System.Collections.Generic;

namespace mvc_skills
{
    public class SkillsRepository : ISkillsRepository{

        public IEnumerable<Skill> GetAllSkills(){
            List<Skill> result = new List<Skill>();
            result.Add(new Skill{ID=1, Name="DevOps"});
            result.Add(new Skill{ID=2, Name="Angular"});
            result.Add(new Skill{ID=3, Name="React"});
            return result;
        }

    }
}