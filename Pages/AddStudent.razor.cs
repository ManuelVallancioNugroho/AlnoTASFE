using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TASfe.Models;
using TASfe.Services;

namespace TASfe.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]

        public IStudent StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected async Task HandleValidSubmit(){
            var result = await StudentService.Add(Student);
            NavigationManager.NavigateTo("/studentpage");
        }
    }
}