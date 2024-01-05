﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StandardRail.RailCarLounge.Data.SqlServer.Pact;
using StandardRail.RailCarLounge.Models.Entities;

namespace StandardRail.RailCarLounge.Data.SqlServer.Repositories
{
    /// <summary>
    /// Performs database operations for Region entity.
    /// </summary>
    public class RegionRepository: BaseRepository<Region, long>, IRepository<Region, long>
    {
        private readonly RailCarLoungeContext _railCarLoungeContext;

        public RegionRepository(RailCarLoungeContext railCarLoungeContext)
        {
            this._railCarLoungeContext = railCarLoungeContext ?? throw new ArgumentNullException(nameof(railCarLoungeContext));
        }

        public override async Task<IList<Region>> GetAll()
        {
            return await Task.Run(
                () => { return this._railCarLoungeContext.Regions.Where(s => s.IsActive.Value).ToList(); });
        }

        public override async Task<IQueryable<Region>> GetByCondition(Expression<Func<Region, bool>> expression)
        {
            return await Task.Run(
                () => { return this._railCarLoungeContext.Regions.Where(expression); });
        }

        public override async Task<IList<Region>> GetListById(long countryID)
        {
            return await Task.Run(
                () => { return this._railCarLoungeContext.Regions.Where(s => s.IsActive == true && s.CountryId == countryID).ToList(); });
        }
    }
}
