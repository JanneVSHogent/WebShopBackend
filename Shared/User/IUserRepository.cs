﻿namespace Shared.User;

public interface IUserRepository
{
    Task<UserResponse.Edit> EditAsync(UserRequest.Edit request);
    Task<UserResponse.Detail> GetUserByIdAsync(UserRequest.Detail request);
}