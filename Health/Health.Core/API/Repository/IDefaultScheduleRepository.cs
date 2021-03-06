﻿using Health.Core.API.Repository.Abstract;
using Health.Core.Entities.POCO;

namespace Health.Core.API.Repository
{
    public interface IDefaultScheduleRepository : ICoreRepository<DefaultSchedule>, IScheduleRepository
    {
        DefaultSchedule GetById(int scheduleId);

        bool DeleteById(int scheduleId);
    }
}
