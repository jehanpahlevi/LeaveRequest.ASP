using System.Web.Mvc;
using LeaveRequest.ASP.BussinessLogic.Repository;
using LeaveRequest.ASP.BussinessLogic.Service;
using LeaveRequest.ASP.Common.Interface;
using LeaveRequest.ASP.Common.Interface.Application;
using Unity;
using Unity.Mvc5;

namespace LeaveRequest.ASP
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IEmployeeLeaveService, EmployeeLeaveService>();
            container.RegisterType<IEmployeeLeaveRepository, EmployeeLeaveRepository>();
            container.RegisterType<IAdminService, AdminService>();
            container.RegisterType<IAdminRepository, AdminRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}