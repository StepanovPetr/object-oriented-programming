using System;
using Chain_of_Responsibility.Enums;

namespace Chain_of_Responsibility
{
    public class FITIXHandler : AbstractHandler
    {
        public override bool Handle(Student request)
        {
            if (request != null && request.Faculty == Faculty.Fitix)
            {
                Console.WriteLine("Студент успешно отчислен Деканатом Фитикс.");
                return true;
            }
            else
            {
                if (NextHandler != null)
                {
                    return NextHandler.Handle(request);
                }
                else
                {
                    Console.WriteLine("К сожалению студента не удалось отчислить.");
                    return false;
                }
            }
        }
    }
}