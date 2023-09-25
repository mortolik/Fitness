namespace Fitness.BL.Test;
using Fitness.BL.UserController;

public class FitnessBLTest

{
    [Fact]
    public void SaveTest()
    {
        var userName = Guid.NewGuid().ToString();
        var _sut = new UserController(userName);
        Assert.Equal(_sut.CurrentUser.Name, userName);
    }
    
    [Fact]
    public void SetNewUserDataTest()
    {
        var userName = Guid.NewGuid().ToString();
        var birthdate = DateTime.Now.AddYears(-18);
        var gender = "man";
        var weight = 80;
        var height = 180;
        var controller = new UserController(userName);
        
        controller.SetNewUserData(gender,birthdate, weight, height);
        var controller2 = new UserController(userName);
        
        Assert.Equal(userName, controller2.CurrentUser.Name);
        Assert.Equal(birthdate, controller2.CurrentUser.Birthdate);
        Assert.Equal(gender, controller2.CurrentUser.Gender.Name);
        Assert.Equal(weight, controller2.CurrentUser.Weight);
        Assert.Equal(height, controller2.CurrentUser.Height);
        

    }
    
    
}