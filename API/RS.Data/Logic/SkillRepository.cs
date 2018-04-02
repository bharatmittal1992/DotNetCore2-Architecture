using RS.Data.Interfaces;
using RS.Entity.Models;

namespace RS.Data.Logic
{
    public class SkillRepository : Repository<Skills>, ISkillRepository
    {
        private readonly RSContext _context;
        public SkillRepository(RSContext context) : base(context) {

            this._context = context;
        }
    }
}
