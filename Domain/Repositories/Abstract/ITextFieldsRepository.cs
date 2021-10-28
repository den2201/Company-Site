namespace My_company.Domain.Repositories.Abstract
{
    using Entities;
    using System;
    using System.Threading.Tasks;

    public interface ITextFieldsRepository
    {
        Task<System.Linq.IQueryable<TextField>> GetTextFieldsAsync();
        Task<TextField> GetByIdAsync(Guid id);
        Task<TextField> GetTextFieldByCodeWordAsync(string codeWord);
        Task SaveTextFieldAsync(TextField textField);
        Task DeleteTextFieldAsync(Guid id);
    }
}
