using System.Collections.Generic;

namespace mvc_skills
{
    public interface ISkillsRepository {
        IEnumerable<Skill> GetAllSkills();
        IEnumerable<Skill> AddSkill(Skill sk);
    }
}