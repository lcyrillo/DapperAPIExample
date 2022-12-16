using Repository.ResponseModel;

namespace Repository;

public interface IAlunoRepository
{
    public Task<List<Aluno>> GetAll();
}

