
using Dapper;
using Microsoft.Extensions.Configuration;
using Repository.ResponseModel;
using System.Data.SqlClient;

namespace Repository;

public class AlunoRepository : IAlunoRepository
{
    private readonly IConfiguration _config;

    public AlunoRepository(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<Aluno>> GetAll()
    {
        using var connection = new SqlConnection(_config.GetConnectionString("SqlServer"));
        var alunos = await connection.QueryAsync<Aluno>("select * from alunos");

        return alunos.ToList();
    }
}

