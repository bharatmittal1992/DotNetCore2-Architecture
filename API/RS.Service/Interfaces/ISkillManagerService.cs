﻿using RS.Common.CommonData;
using RS.ViewModel.Skill;

namespace RS.Service.Interfaces
{
    public interface ISkillManagerService 
    {
        /// <summary>
        /// Create a Skill
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        IResult CreateSkill(SkillViewModel skill);

        /// <summary>
        /// Update a Skill
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        IResult UpdateSkill(SkillViewModel skill);

        /// <summary>
        /// Delete a Skill
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IResult DeleteSkill(int id);

        /// <summary>
        /// Get All Skills
        /// </summary>
        /// <returns></returns>
        IResult GetAllSkill();

        /// <summary>
        /// Get Skill By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IResult GetSkillById(int id);
    }
}
