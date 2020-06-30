using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using cam.Data;
using cam.Models;
using Microsoft.EntityFrameworkCore;

namespace cam.Services
{
    public class ReportService : IReportService
    {
        private readonly ApplicationDbContext context;

        public ReportService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Report>> Get()
        {
            return await context.Reports.ToListAsync();
        }

        public async Task<Report> Get(string id)
        {
            return await context.Reports.Where(r=>r.Id == id).FirstOrDefaultAsync();
        }
        public async Task<Report> Get(string studentId, string period)
        {
            var report = await context.Reports.Where(r => r.StudentId == studentId && r.Period == period).FirstOrDefaultAsync();
            return report != null ? report : new Report();
        }

        public async Task<Report> Insert(Report report)
        {
            context.Reports.Update(report);
            await context.SaveChangesAsync();

            return report;
        }
        public async Task<List<Report>> InsertMany(List<Report> reports)
        {
            await context.Reports.AddRangeAsync(reports);
            await context.SaveChangesAsync();

            return reports;
        }
    }

    public interface IReportService
    {
        Task<List<Report>> Get();
        Task<Report> Get(string id);
        Task<Report> Get(string studentId, string period);
        Task<Report> Insert(Report report);
        public Task<List<Report>> InsertMany(List<Report> reports);
    }
}