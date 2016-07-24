// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.PetstoreV2
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for SwaggerPetstoreV2.
    /// </summary>
    public static partial class SwaggerPetstoreV2Extensions
    {
            /// <summary>
            /// Add a new pet to the store
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Pet object that needs to be added to the store
            /// </param>
            public static Pet AddPet(this ISwaggerPetstoreV2 operations, Pet body)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).AddPetAsync(body), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add a new pet to the store
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Pet object that needs to be added to the store
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Pet> AddPetAsync(this ISwaggerPetstoreV2 operations, Pet body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.AddPetWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Pet object that needs to be added to the store
            /// </param>
            public static void UpdatePet(this ISwaggerPetstoreV2 operations, Pet body)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).UpdatePetAsync(body), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Pet object that needs to be added to the store
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdatePetAsync(this ISwaggerPetstoreV2 operations, Pet body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.UpdatePetWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Finds Pets by status
            /// </summary>
            /// <remarks>
            /// Multiple status values can be provided with comma seperated strings
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='status'>
            /// Status values that need to be considered for filter
            /// </param>
            public static System.Collections.Generic.IList<Pet> FindPetsByStatus(this ISwaggerPetstoreV2 operations, System.Collections.Generic.IList<System.String> status)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).FindPetsByStatusAsync(status), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Finds Pets by status
            /// </summary>
            /// <remarks>
            /// Multiple status values can be provided with comma seperated strings
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='status'>
            /// Status values that need to be considered for filter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<Pet>> FindPetsByStatusAsync(this ISwaggerPetstoreV2 operations, System.Collections.Generic.IList<System.String> status, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.FindPetsByStatusWithHttpMessagesAsync(status, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Finds Pets by tags
            /// </summary>
            /// <remarks>
            /// Muliple tags can be provided with comma seperated strings. Use tag1, tag2,
            /// tag3 for testing.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tags'>
            /// Tags to filter by
            /// </param>
            public static System.Collections.Generic.IList<Pet> FindPetsByTags(this ISwaggerPetstoreV2 operations, System.Collections.Generic.IList<System.String> tags)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).FindPetsByTagsAsync(tags), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Finds Pets by tags
            /// </summary>
            /// <remarks>
            /// Muliple tags can be provided with comma seperated strings. Use tag1, tag2,
            /// tag3 for testing.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tags'>
            /// Tags to filter by
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<Pet>> FindPetsByTagsAsync(this ISwaggerPetstoreV2 operations, System.Collections.Generic.IList<System.String> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.FindPetsByTagsWithHttpMessagesAsync(tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Find pet by Id
            /// </summary>
            /// <remarks>
            /// Returns a single pet
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Id of pet to return
            /// </param>
            public static Pet GetPetById(this ISwaggerPetstoreV2 operations, System.Int64 petId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).GetPetByIdAsync(petId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Find pet by Id
            /// </summary>
            /// <remarks>
            /// Returns a single pet
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Id of pet to return
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Pet> GetPetByIdAsync(this ISwaggerPetstoreV2 operations, System.Int64 petId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetPetByIdWithHttpMessagesAsync(petId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a pet in the store with form data
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Id of pet that needs to be updated
            /// </param>
            /// <param name='fileContent'>
            /// File to upload.
            /// </param>
            /// <param name='fileName'>
            /// Updated name of the pet
            /// </param>
            /// <param name='status'>
            /// Updated status of the pet
            /// </param>
            public static void UpdatePetWithForm(this ISwaggerPetstoreV2 operations, System.Int64 petId, System.IO.Stream fileContent, System.String fileName = default(System.String), System.String status = default(System.String))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).UpdatePetWithFormAsync(petId, fileContent, fileName, status), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a pet in the store with form data
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Id of pet that needs to be updated
            /// </param>
            /// <param name='fileContent'>
            /// File to upload.
            /// </param>
            /// <param name='fileName'>
            /// Updated name of the pet
            /// </param>
            /// <param name='status'>
            /// Updated status of the pet
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdatePetWithFormAsync(this ISwaggerPetstoreV2 operations, System.Int64 petId, System.IO.Stream fileContent, System.String fileName = default(System.String), System.String status = default(System.String), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.UpdatePetWithFormWithHttpMessagesAsync(petId, fileContent, fileName, status, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes a pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Pet id to delete
            /// </param>
            /// <param name='apiKey'>
            /// </param>
            public static void DeletePet(this ISwaggerPetstoreV2 operations, System.Int64 petId, System.String apiKey = "")
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).DeletePetAsync(petId, apiKey), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Pet id to delete
            /// </param>
            /// <param name='apiKey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeletePetAsync(this ISwaggerPetstoreV2 operations, System.Int64 petId, System.String apiKey = "", System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeletePetWithHttpMessagesAsync(petId, apiKey, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns pet inventories by status
            /// </summary>
            /// <remarks>
            /// Returns a map of status codes to quantities
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.Collections.Generic.IDictionary<System.String, System.Int32?> GetInventory(this ISwaggerPetstoreV2 operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).GetInventoryAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns pet inventories by status
            /// </summary>
            /// <remarks>
            /// Returns a map of status codes to quantities
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IDictionary<System.String, System.Int32?>> GetInventoryAsync(this ISwaggerPetstoreV2 operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetInventoryWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Place an order for a pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// order placed for purchasing the pet
            /// </param>
            public static Order PlaceOrder(this ISwaggerPetstoreV2 operations, Order body)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).PlaceOrderAsync(body), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Place an order for a pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// order placed for purchasing the pet
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Order> PlaceOrderAsync(this ISwaggerPetstoreV2 operations, Order body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PlaceOrderWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Find purchase order by Id
            /// </summary>
            /// <remarks>
            /// For valid response try integer IDs with value &lt;= 5 or &gt; 10. Other
            /// values will generated exceptions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// Id of pet that needs to be fetched
            /// </param>
            public static Order GetOrderById(this ISwaggerPetstoreV2 operations, System.String orderId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).GetOrderByIdAsync(orderId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Find purchase order by Id
            /// </summary>
            /// <remarks>
            /// For valid response try integer IDs with value &lt;= 5 or &gt; 10. Other
            /// values will generated exceptions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// Id of pet that needs to be fetched
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Order> GetOrderByIdAsync(this ISwaggerPetstoreV2 operations, System.String orderId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetOrderByIdWithHttpMessagesAsync(orderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete purchase order by Id
            /// </summary>
            /// <remarks>
            /// For valid response try integer IDs with value &lt; 1000. Anything above
            /// 1000 or nonintegers will generate API errors
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// Id of the order that needs to be deleted
            /// </param>
            public static void DeleteOrder(this ISwaggerPetstoreV2 operations, System.String orderId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).DeleteOrderAsync(orderId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete purchase order by Id
            /// </summary>
            /// <remarks>
            /// For valid response try integer IDs with value &lt; 1000. Anything above
            /// 1000 or nonintegers will generate API errors
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// Id of the order that needs to be deleted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteOrderAsync(this ISwaggerPetstoreV2 operations, System.String orderId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteOrderWithHttpMessagesAsync(orderId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Create user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Created user object
            /// </param>
            public static void CreateUser(this ISwaggerPetstoreV2 operations, User body)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).CreateUserAsync(body), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Created user object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CreateUserAsync(this ISwaggerPetstoreV2 operations, User body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.CreateUserWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates list of users with given input array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// List of user object
            /// </param>
            public static void CreateUsersWithArrayInput(this ISwaggerPetstoreV2 operations, System.Collections.Generic.IList<User> body)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).CreateUsersWithArrayInputAsync(body), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates list of users with given input array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// List of user object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CreateUsersWithArrayInputAsync(this ISwaggerPetstoreV2 operations, System.Collections.Generic.IList<User> body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.CreateUsersWithArrayInputWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates list of users with given input array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// List of user object
            /// </param>
            public static void CreateUsersWithListInput(this ISwaggerPetstoreV2 operations, System.Collections.Generic.IList<User> body)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).CreateUsersWithListInputAsync(body), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates list of users with given input array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// List of user object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CreateUsersWithListInputAsync(this ISwaggerPetstoreV2 operations, System.Collections.Generic.IList<User> body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.CreateUsersWithListInputWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Logs user into the system
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The user name for login
            /// </param>
            /// <param name='password'>
            /// The password for login in clear text
            /// </param>
            public static System.String LoginUser(this ISwaggerPetstoreV2 operations, System.String username, System.String password)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).LoginUserAsync(username, password), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Logs user into the system
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The user name for login
            /// </param>
            /// <param name='password'>
            /// The password for login in clear text
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.String> LoginUserAsync(this ISwaggerPetstoreV2 operations, System.String username, System.String password, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.LoginUserWithHttpMessagesAsync(username, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Logs out current logged in user session
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void LogoutUser(this ISwaggerPetstoreV2 operations)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).LogoutUserAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Logs out current logged in user session
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task LogoutUserAsync(this ISwaggerPetstoreV2 operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.LogoutUserWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get user by user name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The name that needs to be fetched. Use user1 for testing.
            /// </param>
            public static User GetUserByName(this ISwaggerPetstoreV2 operations, System.String username)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).GetUserByNameAsync(username), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get user by user name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The name that needs to be fetched. Use user1 for testing.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<User> GetUserByNameAsync(this ISwaggerPetstoreV2 operations, System.String username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetUserByNameWithHttpMessagesAsync(username, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updated user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// name that need to be deleted
            /// </param>
            /// <param name='body'>
            /// Updated user object
            /// </param>
            public static void UpdateUser(this ISwaggerPetstoreV2 operations, System.String username, User body)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).UpdateUserAsync(username, body), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updated user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// name that need to be deleted
            /// </param>
            /// <param name='body'>
            /// Updated user object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdateUserAsync(this ISwaggerPetstoreV2 operations, System.String username, User body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.UpdateUserWithHttpMessagesAsync(username, body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The name that needs to be deleted
            /// </param>
            public static void DeleteUser(this ISwaggerPetstoreV2 operations, System.String username)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerPetstoreV2)s).DeleteUserAsync(username), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The name that needs to be deleted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteUserAsync(this ISwaggerPetstoreV2 operations, System.String username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteUserWithHttpMessagesAsync(username, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
