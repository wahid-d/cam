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
        Task<string> Insert(Student student);
        Task<string> InsertRange(List<Student> student);
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
            var @class = await _context.Classes.Where(c => c.Id == classId).FirstOrDefaultAsync();
            if(@class == null)
                return new List<Student>();
            
            if(@class.Name.ToLower() == "unsorted")
                return await _context.Students.Where(s => (s.ClassId == classId || string.IsNullOrWhiteSpace(s.ClassId))).ToListAsync();

            return await _context.Students.Where(s => s.ClassId == classId).ToListAsync();
        }
        public async Task<Student> Get(string id)
        {
            return await _context.Students.Where(s => s.Id == id).FirstOrDefaultAsync();
        }

        public async Task<string> Insert(Student student)
        {
            if(_context.Students.Any(s => s.ParentPhone == student.ParentPhone))
                return $"Student {student.EnglishName} {student.KoreanName} exists in Database... \n";
            if(_context.Students.Any(s => s.SelfPhone == student.SelfPhone))
                return $"Student {student.EnglishName} {student.KoreanName} exists in Database... \n";

            if(string.IsNullOrWhiteSpace(student.SelfPhone) && string.IsNullOrWhiteSpace(student.ParentPhone))
                return $"Student {student.EnglishName} {student.KoreanName} does NOT have any PHONE... \n";


            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            return "";
        }
        public async Task<string> InsertRange(List<Student> students)
        {

            if(students == null || students.Count < 1)
                return "Collection is empty ...";

            string message = "";
            foreach(var student in students)
            {
                if(_context.Students.Any(s => s.ParentPhone == student.ParentPhone) 
                    || _context.Students.Any(s => s.SelfPhone == student.SelfPhone))
                {
                    message += $"Student {student.EnglishName} {student.KoreanName} exists in Database... \n";
                    continue;
                }

                if(string.IsNullOrWhiteSpace(student.SelfPhone) 
                    && string.IsNullOrWhiteSpace(student.ParentPhone))
                {
                    message += $"Student {student.EnglishName} {student.KoreanName} does NOT have any PHONE... \n";
                    continue;
                }
                await _context.Students.AddAsync(student);
            }

            await _context.SaveChangesAsync();
            return message;
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