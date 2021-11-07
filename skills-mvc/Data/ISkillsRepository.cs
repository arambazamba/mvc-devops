using System.Collections.Generic;

namespace skills
{
    public interface ISkillsRepository {
        IEnumerable<Skill> GetAllSkills();
        IEnumerable<Skill> AddSkill(Skill sk);
    }
}