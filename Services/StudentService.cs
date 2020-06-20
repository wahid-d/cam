using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using cam.Data;
using cam.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace cam.Services
{
    public interface IStudentService
    {
        Task<List<Student>> Get();
        Task<List<Student>> GetForClass(string classId);
        Task<Student> Get(string id);
        Task<Student> Insert(Student student);
        Task<Student> Update(Student student);
        Task UpdateRange(List<Student> students);
        Task Delete(string id);
        Task Delete(Student student);
    }

    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Delete(string id)
        {
            var student = await Get(id);
            await Delete(student);
        }

        public async Task Delete(Student student)
        {
            try
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public async Task<List<Student>> Get()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<List<Student>> GetForClass(string classId)
        {
            return await _context.Students.Where(s => s.ClassId == classId).ToListAsync();
        }
        public async Task<Student> Get(string id)
        {
            return await _context.Students.Where(s => s.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Student> Insert(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<Student> Update(Student student)
        {
            var s = await _context.Students.Where(s => s.Id == student.Id).FirstOrDefaultAsync();
            s.ClassId = student.ClassId;
            _context.Students.Update(s);
            await _context.SaveChangesAsync();
            return student;
        }
        public async Task UpdateRange(List<Student> students)
        {
            _context.Students.UpdateRange(students);
            await _context.SaveChangesAsync();
        }
    }
}