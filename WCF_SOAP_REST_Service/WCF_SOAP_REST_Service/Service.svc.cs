using System.ServiceModel.Activation;

namespace WCF_SOAP_REST_Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class Service : IService
    {
        public Employee[] GetEmployees()
        {
            return new Employee[]
             {
                  new Employee() {EmpNo=101,EmpName="John Kinyua",DeptName="Software"},
                  new Employee() {EmpNo=102,EmpName="Bimi Syla",DeptName="Software"},
                  new Employee() {EmpNo=103, EmpName="David", DeptName="Engineering"}
             };
        }
    }
}
