using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using cam.Data;
using cam.Models;
using Microsoft.EntityFrameworkCore;

namespace cam.Services
{
    public interface IStudentService
    {
        Task<List<Student>> Get();
        // Task<Student> Get(int id);
        Task<Student> Insert(Student student);
        // Task<Student> Update(ToDo toDo);
        // Task<Student> Delete(int id);
    }

    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> Get()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> Insert(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            return student;
        }

    }
}