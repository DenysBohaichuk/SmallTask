using Microsoft.AspNetCore.Mvc.ApplicationModels;


namespace WebApplication1.Infrastructure
{
    public class Redirection : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {

          //  controller.ControllerName = controller.ControllerName.Replace("ControllerDen", string.Empty);
            controller.ControllerName = controller.ControllerName.Remove(5);
        }
    }
}
