using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using SmartHub.Domain;

namespace SmartHub.DB;
[ExcludeFromCodeCoverage]
public class SmartHubAPIContext : DbContext
{
    public SmartHubAPIContext(DbContextOptions<SmartHubAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Device> Devices { get; set; }
    public DbSet<SessionUser> Sessions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Hardware> Hardwares { get; set; }
    public DbSet<Home> Homes { get; set; }
    public DbSet<UserHomePermission> UserHomePermissions { get; set; }
    public DbSet<NotificationMember> NotificationMembers { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<UserPermissions> UserPermissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SessionUser>()
            .HasOne(su => su.User)
            .WithMany()
            .HasForeignKey(su => su.UserId);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Permissions)
            .WithMany()
            .UsingEntity<UserPermissions>(j =>
                j.ToTable("UserPermissions"));

        modelBuilder.Entity<Home>()
            .OwnsOne(h => h.Ubication);

        modelBuilder.Entity<Home>()
            .HasOne(h => h.Owner)
            .WithMany(u => u.OwnedHomes)
            .HasForeignKey(h => h.OwnerId);

        modelBuilder.Entity<UserHomePermission>()
            .HasOne(uhp => uhp.Home)
            .WithMany(h => h.Members)
            .HasForeignKey(uhp => uhp.HomeId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<UserHomePermission>()
            .HasOne(uhp => uhp.User)
            .WithMany(u => u.HomePermissions)
            .HasForeignKey(uhp => uhp.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<NotificationMember>()
            .HasOne(n => n.Home)
            .WithMany(h => h.NotificationMembers)
            .HasForeignKey(n => n.HomeId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<NotificationMember>()
            .HasOne(n => n.User)
            .WithMany()
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Home>()
            .HasMany(h => h.Devices)
            .WithOne(hw => hw.Home)
            .HasForeignKey(hw => hw.HomeId);

        modelBuilder.Entity<Company>()
            .HasOne(c => c.Owner)
            .WithOne()
            .HasForeignKey<Company>(c => c.OwnerId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.Devices)
            .WithOne(d => d.Company)
            .HasForeignKey(d => d.CompanyId);

        modelBuilder.Entity<Hardware>()
            .ToTable("Hardwares")
            .HasDiscriminator<string>("HardwareType")
            .HasValue<Hardware>("Hardware")
            .HasValue<WindowSensorHardware>("WindowSensor")
            .HasValue<SmartLampHardware>("SmartLamp");

        modelBuilder.Entity<Hardware>()
            .HasOne(h => h.Device)
            .WithMany()
            .HasForeignKey(h => h.DeviceId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Notification>()
            .HasOne(n => n.Hardware)
            .WithMany()
            .HasForeignKey(n => n.HardwareId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Notification>()
            .HasOne(n => n.User)
            .WithMany()
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Device>()
            .ToTable("Devices")
            .HasDiscriminator<string>("DeviceType")
            .HasValue<Device>("Device")
            .HasValue<SecurityCam>("SecurityCam");

        SeedUsers(modelBuilder);
    }

    private void SeedUsers(ModelBuilder modelBuilder)
    {
        var permissionsForAll = new List<Permission>
    {
        // Permisos para Todos
        new Permission { Id = Guid.NewGuid(), Name = "getnotifications-notification" },
        new Permission { Id = Guid.NewGuid(), Name = "open-windowsensor" },
        new Permission { Id = Guid.NewGuid(), Name = "close-windowsensor" },
        new Permission { Id = Guid.NewGuid(), Name = "motiondetection-camera" },
        new Permission { Id = Guid.NewGuid(), Name = "persondetection-camera" },
        new Permission { Id = Guid.NewGuid(), Name = "getdevices-devices" },
        new Permission { Id = Guid.NewGuid(), Name = "getdevicetypes-devicetype" },
        new Permission { Id = Guid.NewGuid(), Name = "motiondetection-motionsensor" },
        new Permission { Id = Guid.NewGuid(), Name = "on-smartlamp" },
        new Permission { Id = Guid.NewGuid(), Name = "off-smartlamp" },
        new Permission { Id = Guid.NewGuid(), Name = "getpermissions-home" },
        new Permission { Id = Guid.NewGuid(), Name = "changeprofilephoto-user" }
    };
        var permissionsCompanyOwner = new List<Permission>
    {
            // Permisos para Company Owner
        new Permission { Id = Guid.NewGuid(), Name = "createcompany-companies" },
        new Permission { Id = Guid.NewGuid(), Name = "addsensor-windowsensor" },
        new Permission { Id = Guid.NewGuid(), Name = "addmotionsensor-motionsensor" },
        new Permission { Id = Guid.NewGuid(), Name = "addcamera-camera" },
        new Permission { Id = Guid.NewGuid(), Name = "addhomeownerpermission-homeowner" },
        new Permission { Id = Guid.NewGuid(), Name = "addsmartlamp-smartlamp" },
        new Permission { Id = Guid.NewGuid(), Name = "importdevices-devices" },
        new Permission { Id = Guid.NewGuid(), Name = "getimporters-devices" },
        new Permission { Id = Guid.NewGuid(), Name = "getcompanyuser-companies" },
        new Permission { Id = Guid.NewGuid(), Name = "getdevicemodelvalidators-devices" },
        new Permission { Id = Guid.NewGuid(), Name = "selectdevicemodelvalidator-devices" }
    };

        var permissionsAdministrator = new List<Permission>
    {
        // Permisos para Administrator
        new Permission { Id = Guid.NewGuid(), Name = "createadminaccount-administrator" },
        new Permission { Id = Guid.NewGuid(), Name = "deleteadminaccount-administrator" },
        new Permission { Id = Guid.NewGuid(), Name = "createcompanyowneraccount-companyowner" },
        new Permission { Id = Guid.NewGuid(), Name = "getaccounts-accounts" },
        new Permission { Id = Guid.NewGuid(), Name = "getcompany-companies" },
        new Permission { Id = Guid.NewGuid(), Name = "addhomeownerpermission-homeowner" }
    };

        var permissionsHomeOwner = new List<Permission>
    {
        // Permisos para Home Owner
        new Permission { Id = Guid.NewGuid(), Name = "getrooms-home" },
        new Permission { Id = Guid.NewGuid(), Name = "getemails-homeowner" },
        new Permission { Id = Guid.NewGuid(), Name = "add-home" },
        new Permission { Id = Guid.NewGuid(), Name = "addmember-members" },
        new Permission { Id = Guid.NewGuid(), Name = "adddevice-home" },
        new Permission { Id = Guid.NewGuid(), Name = "getmembers-members" },
        new Permission { Id = Guid.NewGuid(), Name = "getdevices-home" },
        new Permission { Id = Guid.NewGuid(), Name = "addnotificationmembers-members" },
        new Permission { Id = Guid.NewGuid(), Name = "updatenamedevice-home" },
        new Permission { Id = Guid.NewGuid(), Name = "addmotionsensor-motionsensor" },
        new Permission { Id = Guid.NewGuid(), Name = "gethomes-user" },
        new Permission { Id = Guid.NewGuid(), Name = "addpermission-members" },
        new Permission { Id = Guid.NewGuid(), Name = "addrooms-home" },
        new Permission { Id = Guid.NewGuid(), Name = "updateroomdevice-home" },
        new Permission { Id = Guid.NewGuid(), Name = "hardwareon-home" },
        new Permission { Id = Guid.NewGuid(), Name = "hardwareoff-home" }
    };

        modelBuilder.Entity<Permission>().HasData(permissionsForAll);
        modelBuilder.Entity<Permission>().HasData(permissionsCompanyOwner);
        modelBuilder.Entity<Permission>().HasData(permissionsAdministrator);
        modelBuilder.Entity<Permission>().HasData(permissionsHomeOwner);

        var mockUsers = new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Roger",
                Surname = "Federer",
                Email = "rogerfederer@tennis.com",
                Password = "Federer@123",
                ProfilePhoto = "federer.jpg",
                Roles = [Role.CompanyOwner]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Rafael",
                Surname = "Nadal",
                Email = "rafaelnadal@tennis.com",
                Password = "Nadal@123",
                ProfilePhoto = "nadal.jpg",
                Roles = [Role.CompanyOwner]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Serena",
                Surname = "Williams",
                Email = "serenawilliams@tennis.com",
                Password = "Serena@123",
                ProfilePhoto = "serena.jpg",
                Roles = [Role.Administrator]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Novak",
                Surname = "Djokovic",
                Email = "novakdjokovic@tennis.com",
                Password = "Djokovic@123",
                ProfilePhoto = "djokovic.jpg",
                Roles = [Role.Administrator, Role.HomeOwner]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Steffi",
                Surname = "Graf",
                Email = "steffigraf@tennis.com",
                Password = "Steffi@123",
                ProfilePhoto = "graf.jpg",
                Roles = [Role.HomeOwner]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Andre",
                Surname = "Agassi",
                Email = "andreagassi@tennis.com",
                Password = "Agassi@123",
                ProfilePhoto = "agassi.jpg",
                Roles = [Role.HomeOwner]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Pete",
                Surname = "Sampras",
                Email = "petesampras@tennis.com",
                Password = "Sampras@123",
                ProfilePhoto = "sampras.jpg",
                Roles = [Role.HomeOwner]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Martina",
                Surname = "Navratilova",
                Email = "martinanavratilova@tennis.com",
                Password = "Navratilova@123",
                ProfilePhoto = "navratilova.jpg",
                Roles = [Role.HomeOwner]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "John",
                Surname = "McEnroe",
                Email = "johnmcenroe@tennis.com",
                Password = "McEnroe@123",
                ProfilePhoto = "mcenroe.jpg",
                Roles = [Role.Administrator]
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Billie",
                Surname = "Jean King",
                Email = "billiejeanking@tennis.com",
                Password = "King@123",
                ProfilePhoto = "king.jpg",
                Roles = [Role.CompanyOwner]
            }
        };

        modelBuilder.Entity<User>().HasData(mockUsers);

        foreach (var user in mockUsers)
        {
            var userPermissions = new List<UserPermissions>();

            if (user.Roles.Contains(Role.CompanyOwner))
            {
                userPermissions.AddRange(permissionsCompanyOwner.Select(permission => new UserPermissions { UserId = user.Id, PermissionId = permission.Id }));
            }

            if (user.Roles.Contains(Role.Administrator))
            {
                userPermissions.AddRange(permissionsAdministrator.Select(permission => new UserPermissions { UserId = user.Id, PermissionId = permission.Id }));
            }

            if (user.Roles.Contains(Role.HomeOwner))
            {
                userPermissions.AddRange(permissionsHomeOwner.Select(permission => new UserPermissions { UserId = user.Id, PermissionId = permission.Id }));
            }

            userPermissions.AddRange(permissionsForAll.Select(permission => new UserPermissions { UserId = user.Id, PermissionId = permission.Id }));

            modelBuilder.Entity<UserPermissions>().HasData(userPermissions);
        }
    }

    /*
        private void SeedHomes(ModelBuilder modelBuilder, List<User> mockUsers)
        {
            var mockHomes = new List<Home>
            {
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Novak Villa",
                    Street = "Elm Street",
                    StreetNumber = "10",
                    Ubication = new UbicationGeo(46, 6),
                    OwnerId = mockUsers.First(u => u.Name == "Novak").Id,
                    MaxMembers = 5
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Pete Residence",
                    Street = "Palm Street",
                    StreetNumber = "23",
                    Ubication = new UbicationGeo(39, 2),
                    OwnerId = mockUsers.First(u => u.Name == "Pete").Id,
                    MaxMembers = 4
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Steffi House",
                    Street = "Maple Avenue",
                    StreetNumber = "33",
                    Ubication = new UbicationGeo(34, -118),
                    OwnerId = mockUsers.First(u => u.Name == "Steffi").Id,
                    MaxMembers = 3
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Djokovic Estate",
                    Street = "Willow Road",
                    StreetNumber = "14",
                    Ubication = new UbicationGeo(44, 20),
                    OwnerId = mockUsers.First(u => u.Name == "Novak").Id,
                    MaxMembers = 6
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Steffi Manor",
                    Street = "Oak Lane",
                    StreetNumber = "7",
                    Ubication = new UbicationGeo(48, 2),
                    OwnerId = mockUsers.First(u => u.Name == "Steffi").Id,
                    MaxMembers = 2
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Andre Place",
                    Street = "Birch Way",
                    StreetNumber = "9",
                    Ubication = new UbicationGeo(36, -115),
                    OwnerId = mockUsers.First(u => u.Name == "Andre").Id,
                    MaxMembers = 3
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Pete Villa",
                    Street = "Pine Court",
                    StreetNumber = "21",
                    Ubication = new UbicationGeo(40, -74),
                    OwnerId = mockUsers.First(u => u.Name == "Pete").Id,
                    MaxMembers = 4
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Navratilova Residence",
                    Street = "Cedar Road",
                    StreetNumber = "18",
                    Ubication = new UbicationGeo(51, 0),
                    OwnerId = mockUsers.First(u => u.Name == "Martina").Id,
                    MaxMembers = 5
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Steffi Mansion",
                    Street = "Spruce Drive",
                    StreetNumber = "12",
                    Ubication = new UbicationGeo(40, -73),
                    OwnerId = mockUsers.First(u => u.Name == "Steffi").Id,
                    MaxMembers = 3
                },
                new Home
                {
                    Id = Guid.NewGuid(),
                    Name = "Martina Jean King House",
                    Street = "Fir Street",
                    StreetNumber = "8",
                    Ubication = new UbicationGeo(40, -73),
                    OwnerId = mockUsers.First(u => u.Name == "Martina").Id,
                    MaxMembers = 6
                }
            };

            var mockUserPermissions = new List<UserHomePermission>
            {
                // Novak Villa
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Pete").Id,
                    User = mockUsers.First(u => u.Name == "Pete"),
                    Permissions = [HomePermission.AssociateDevices, HomePermission.ListDevices],
                    HomeId = mockHomes.First(h => h.Name == "Novak Villa").Id,
                    Home = mockHomes.First(h => h.Name == "Novak Villa")
                },
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Steffi").Id,
                    User = mockUsers.First(u => u.Name == "Steffi"),
                    Permissions = [HomePermission.ListDevices, HomePermission.ChangeDeviceName],
                    HomeId = mockHomes.First(h => h.Name == "Novak Villa").Id,
                    Home = mockHomes.First(h => h.Name == "Novak Villa")
                },
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Andre").Id,
                    User = mockUsers.First(u => u.Name == "Andre"),
                    Permissions = [],
                    HomeId = mockHomes.First(h => h.Name == "Novak Villa").Id,
                    Home = mockHomes.First(h => h.Name == "Novak Villa")
                },

                // Pete Residence
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Andre").Id,
                    User = mockUsers.First(u => u.Name == "Andre"),
                    Permissions = [HomePermission.AssociateDevices, HomePermission.ChangeDeviceName],
                    HomeId = mockHomes.First(h => h.Name == "Pete Residence").Id,
                    Home = mockHomes.First(h => h.Name == "Pete Residence")
                },
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Martina").Id,
                    User = mockUsers.First(u => u.Name == "Martina"),
                    Permissions = [HomePermission.ListDevices],
                    HomeId = mockHomes.First(h => h.Name == "Pete Residence").Id,
                    Home = mockHomes.First(h => h.Name == "Pete Residence")
                },

                // Steffi House
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Novak").Id,
                    User = mockUsers.First(u => u.Name == "Novak"),
                    Permissions = [HomePermission.ListDevices, HomePermission.AssociateDevices],
                    HomeId = mockHomes.First(h => h.Name == "Steffi House").Id,
                    Home = mockHomes.First(h => h.Name == "Steffi House")
                },

                // Djokovic Estate
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Andre").Id,
                    User = mockUsers.First(u => u.Name == "Andre"),
                    Permissions = [HomePermission.AssociateDevices],
                    HomeId = mockHomes.First(h => h.Name == "Djokovic Estate").Id,
                    Home = mockHomes.First(h => h.Name == "Djokovic Estate")
                },

                // Andre Place
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Pete").Id,
                    User = mockUsers.First(u => u.Name == "Pete"),
                    Permissions = [HomePermission.ChangeDeviceName, HomePermission.ListDevices],
                    HomeId = mockHomes.First(h => h.Name == "Andre Place").Id,
                    Home = mockHomes.First(h => h.Name == "Andre Place")
                },

                // Navratilova Residence
                new UserHomePermission
                {
                    Id = Guid.NewGuid(),
                    UserId = mockUsers.First(u => u.Name == "Steffi").Id,
                    User = mockUsers.First(u => u.Name == "Steffi"),
                    Permissions = [HomePermission.AssociateDevices, HomePermission.ListDevices],
                    HomeId = mockHomes.First(h => h.Name == "Navratilova Residence").Id,
                    Home = mockHomes.First(h => h.Name == "Navratilova Residence")
                }
            };

            var mockNotificationMembers = new List<NotificationMember>
            {
                // Novak Villa
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Novak Villa").Id,
                    UserId = mockUsers.First(u => u.Name == "Pete").Id,
                    User = mockUsers.First(u => u.Name == "Pete")
                },
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Novak Villa").Id,
                    UserId = mockUsers.First(u => u.Name == "Steffi").Id,
                    User = mockUsers.First(u => u.Name == "Steffi")
                },

                // Pete Residence
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Pete Residence").Id,
                    UserId = mockUsers.First(u => u.Name == "Andre").Id,
                    User = mockUsers.First(u => u.Name == "Andre")
                },
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Pete Residence").Id,
                    UserId = mockUsers.First(u => u.Name == "Martina").Id,
                    User = mockUsers.First(u => u.Name == "Martina")
                },

                // Steffi House
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Steffi House").Id,
                    UserId = mockUsers.First(u => u.Name == "Novak").Id,
                    User = mockUsers.First(u => u.Name == "Novak")
                },
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Steffi House").Id,
                    UserId = mockUsers.First(u => u.Name == "Andre").Id,
                    User = mockUsers.First(u => u.Name == "Andre")
                },

                // Djokovic Estate
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Djokovic Estate").Id,
                    UserId = mockUsers.First(u => u.Name == "Steffi").Id,
                    User = mockUsers.First(u => u.Name == "Steffi")
                },
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Djokovic Estate").Id,
                    UserId = mockUsers.First(u => u.Name == "Martina").Id,
                    User = mockUsers.First(u => u.Name == "Martina")
                },

                // Andre Place
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Andre Place").Id,
                    UserId = mockUsers.First(u => u.Name == "Pete").Id,
                    User = mockUsers.First(u => u.Name == "Pete")
                },
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Andre Place").Id,
                    UserId = mockUsers.First(u => u.Name == "Steffi").Id,
                    User = mockUsers.First(u => u.Name == "Steffi")
                },

                // Navratilova Residence
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Navratilova Residence").Id,
                    UserId = mockUsers.First(u => u.Name == "Martina").Id,
                    User = mockUsers.First(u => u.Name == "Martina")
                },
                new NotificationMember
                {
                    Id = Guid.NewGuid(),
                    HomeId = mockHomes.First(h => h.Name == "Navratilova Residence").Id,
                    UserId = mockUsers.First(u => u.Name == "Novak").Id,
                    User = mockUsers.First(u => u.Name == "Novak")
                }
            };

             modelBuilder.Entity<Home>().HasData(mockHomes);
             modelBuilder.Entity<UserHomePermission>().HasData(mockUserPermissions);
             modelBuilder.Entity<NotificationMember>().HasData(mockNotificationMembers);
        }
    */
}
