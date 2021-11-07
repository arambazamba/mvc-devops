
using System.Collections;
using System.Collections.Generic;

namespace skills
{
    public class SkillsRepository : ISkillsRepository{

        List<Skill> data;

        public int Items { get{return data.Count;}}

        public SkillsRepository(){
            data = new List<Skill>();
            data.Add(new Skill{ID=1, Name="DevOps"});
            data.Add(new Skill{ID=2, Name="Angular"});
            data.Add(new Skill{ID=3, Name="React"});
        }

        public IEnumerable<Skill> GetAllSkills(){
            return data;
        }

        public IEnumerable<Skill> AddSkill(Skill sk){
            this.data.Add(sk);
            return data;
        }

    }
}