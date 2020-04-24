using System;
using Chain_of_Responsibility.Enums;

namespace Chain_of_Responsibility
{
    public class MsiHandler : AbstractHandler
    {
        public override bool Handle(Student request)
        {
            if (request != null && request.Faculty == Faculty.Msi)
            {
                Console.WriteLine("Студент успешно отчислен Деканатом МСИ.");
                return true;
            }

            if (NextHandler != null)
                return NextHandler.Handle(request);

            Console.WriteLine("К сожалению студента не удалось отчислить.");
            return false;
        }
    }
}