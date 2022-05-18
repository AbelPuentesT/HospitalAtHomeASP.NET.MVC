using HospitalAtHome.App.Model.AppRepository.RepNurse;
using HospitalAtHome.App.Model.AppRepository;
using HospitalAtHome.App.Model.AppRepository.RepDesignatedFamilyMember;
using HospitalAtHome.App.Model.AppRepository.RepMedical;
using HospitalAtHome.App.Model.AppRepository.RepPatient;
using HospitalAtHome.App.Model.AppData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IRepositoryNurse>(new RepositoryNurse(new myAppContext()));
builder.Services.AddSingleton<IRepositoryDesignatedFamilyMember>(new RepositoryDesignatedFamilyMember(new myAppContext()));
builder.Services.AddSingleton<IRepositoryMedical>(new RepositoryMedical(new myAppContext()));
builder.Services.AddSingleton<IRepositoryPatient>(new RepositoryPatient(new myAppContext()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
