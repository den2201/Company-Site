using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_company.Domain.Entities;
using My_company.Domain.Repositories.Abstract;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace My_company.Domain.Repositories
{
    public class TextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext _appDbContext;

        public TextFieldsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task DeleteTextFieldAsync(Guid id)
        {
            var textField = await _appDbContext.TextFields.FirstOrDefaultAsync(x => x.Id == id);
           
           _appDbContext.TextFields.Remove(textField);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<TextField> GetByIdAsync(Guid id)
        {
            return await _appDbContext.TextFields.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TextField> GetTextFieldByCodeWordAsync(string codeWord)
        {
           return await _appDbContext.TextFields.FirstOrDefaultAsync(x=> x.CodeWord == codeWord);
        }

        public async Task<IQueryable<TextField>> GetTextFieldsAsync()
        {
            return  _appDbContext.TextFields;
        }

        public async Task SaveTextFieldAsync(TextField textField)
        {
            if(textField.Id == default)
            {
                _appDbContext.Entry(textField).State = EntityState.Added;
            }
            else
            {
                _appDbContext.Entry(textField).State = EntityState.Modified;
            }
            await _appDbContext.SaveChangesAsync();
        }
    }
}
