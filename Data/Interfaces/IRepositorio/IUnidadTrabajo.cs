using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {
        IEspecialidadRepositorio Especialidad { get; }

        IMedicoRepositorio Medico { get; }

        IAntecedenteRepositorio Antecedente { get; }

        IHistoriaClinicaRepositorio HistoriaClinica { get; }

        IPacienteRepositorio Paciente { get; }
        Task Guardar();
    }
}
