/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Lightsail.Model;

namespace Amazon.Lightsail
{
    /// <summary>
    /// Interface for accessing Lightsail
    ///
    /// Amazon Lightsail is the easiest way to get started with AWS for developers who just
    /// need virtual private servers. Lightsail includes everything you need to launch your
    /// project quickly - a virtual machine, SSD-based storage, data transfer, DNS management,
    /// and a static IP - for a low, predictable price. You manage those Lightsail servers
    /// through the Lightsail console or by using the API or command-line interface (CLI).
    /// 
    ///  
    /// <para>
    /// For more information about Lightsail concepts and tasks, see the <a href="https://lightsail.aws.amazon.com/ls/docs/all">Lightsail
    /// Dev Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To use the Lightsail API or the CLI, you will need to use AWS Identity and Access
    /// Management (IAM) to generate access keys. For details about how to set this up, see
    /// the <a href="http://lightsail.aws.amazon.com/ls/docs/how-to/article/lightsail-how-to-set-up-access-keys-to-use-sdk-api-cli">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonLightsail : IAmazonService, IDisposable
    {

        
        #region  AllocateStaticIp


        /// <summary>
        /// Allocates a static IP address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateStaticIp service method.</param>
        /// 
        /// <returns>The response from the AllocateStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        AllocateStaticIpResponse AllocateStaticIp(AllocateStaticIpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AllocateStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        Task<AllocateStaticIpResponse> AllocateStaticIpAsync(AllocateStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachStaticIp


        /// <summary>
        /// Attaches a static IP address to a specific Amazon Lightsail instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachStaticIp service method.</param>
        /// 
        /// <returns>The response from the AttachStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        AttachStaticIpResponse AttachStaticIp(AttachStaticIpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AttachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        Task<AttachStaticIpResponse> AttachStaticIpAsync(AttachStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CloseInstancePublicPorts


        /// <summary>
        /// Closes the public ports on a specific Amazon Lightsail instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the CloseInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        CloseInstancePublicPortsResponse CloseInstancePublicPorts(CloseInstancePublicPortsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CloseInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloseInstancePublicPorts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        Task<CloseInstancePublicPortsResponse> CloseInstancePublicPortsAsync(CloseInstancePublicPortsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a domain resource for the specified domain (e.g., example.com).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomainEntry


        /// <summary>
        /// Creates one of the following entry records associated with the domain: A record, CNAME
        /// record, TXT record, or MX record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainEntry service method.</param>
        /// 
        /// <returns>The response from the CreateDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        CreateDomainEntryResponse CreateDomainEntry(CreateDomainEntryRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        Task<CreateDomainEntryResponse> CreateDomainEntryAsync(CreateDomainEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstances


        /// <summary>
        /// Creates one or more Amazon Lightsail virtual private servers, or <i>instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstances service method.</param>
        /// 
        /// <returns>The response from the CreateInstances service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        CreateInstancesResponse CreateInstances(CreateInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        Task<CreateInstancesResponse> CreateInstancesAsync(CreateInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstancesFromSnapshot


        /// <summary>
        /// Uses a specific snapshot as a blueprint for creating one or more new instances that
        /// are based on that identical configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstancesFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateInstancesFromSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        CreateInstancesFromSnapshotResponse CreateInstancesFromSnapshot(CreateInstancesFromSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstancesFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstancesFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        Task<CreateInstancesFromSnapshotResponse> CreateInstancesFromSnapshotAsync(CreateInstancesFromSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstanceSnapshot


        /// <summary>
        /// Creates a snapshot of a specific virtual private server, or <i>instance</i>. You can
        /// use a snapshot to create a new instance that is based on that snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        CreateInstanceSnapshotResponse CreateInstanceSnapshot(CreateInstanceSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshotAsync(CreateInstanceSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateKeyPair


        /// <summary>
        /// Creates sn SSH key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes the specified domain recordset and all of its domain records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomainEntry


        /// <summary>
        /// Deletes a specific domain entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        DeleteDomainEntryResponse DeleteDomainEntry(DeleteDomainEntryRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        Task<DeleteDomainEntryResponse> DeleteDomainEntryAsync(DeleteDomainEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInstance


        /// <summary>
        /// Deletes a specific Amazon Lightsail virtual private server, or <i>instance</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInstanceSnapshot


        /// <summary>
        /// Deletes a specific snapshot of a virtual private server (or <i>instance</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        DeleteInstanceSnapshotResponse DeleteInstanceSnapshot(DeleteInstanceSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotAsync(DeleteInstanceSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteKeyPair


        /// <summary>
        /// Deletes a specific SSH key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachStaticIp


        /// <summary>
        /// Detaches a static IP from the Amazon Lightsail instance to which it is attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachStaticIp service method.</param>
        /// 
        /// <returns>The response from the DetachStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        DetachStaticIpResponse DetachStaticIp(DetachStaticIpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        Task<DetachStaticIpResponse> DetachStaticIpAsync(DetachStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DownloadDefaultKeyPair


        /// <summary>
        /// Downloads the default SSH key pair from the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDefaultKeyPair service method.</param>
        /// 
        /// <returns>The response from the DownloadDefaultKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        DownloadDefaultKeyPairResponse DownloadDefaultKeyPair(DownloadDefaultKeyPairRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDefaultKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDefaultKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        Task<DownloadDefaultKeyPairResponse> DownloadDefaultKeyPairAsync(DownloadDefaultKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetActiveNames


        /// <summary>
        /// Returns the names of all active (not deleted) resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetActiveNames service method.</param>
        /// 
        /// <returns>The response from the GetActiveNames service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        GetActiveNamesResponse GetActiveNames(GetActiveNamesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetActiveNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetActiveNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        Task<GetActiveNamesResponse> GetActiveNamesAsync(GetActiveNamesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBlueprints


        /// <summary>
        /// Returns the list of available instance images, or <i>blueprints</i>. You can use a
        /// blueprint to create a new virtual private server already running a specific operating
        /// system, as well as a preinstalled app or development stack. The software each instance
        /// is running depends on the blueprint image you choose.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprints service method.</param>
        /// 
        /// <returns>The response from the GetBlueprints service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        GetBlueprintsResponse GetBlueprints(GetBlueprintsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        Task<GetBlueprintsResponse> GetBlueprintsAsync(GetBlueprintsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBundles


        /// <summary>
        /// Returns the list of bundles that are available for purchase. A bundle describes the
        /// specs for your virtual private server (or <i>instance</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBundles service method.</param>
        /// 
        /// <returns>The response from the GetBundles service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        GetBundlesResponse GetBundles(GetBundlesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBundles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        Task<GetBundlesResponse> GetBundlesAsync(GetBundlesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomain


        /// <summary>
        /// Returns information about a specific domain recordset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        GetDomainResponse GetDomain(GetDomainRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomains


        /// <summary>
        /// Returns a list of all domains in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomains service method.</param>
        /// 
        /// <returns>The response from the GetDomains service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        GetDomainsResponse GetDomains(GetDomainsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        Task<GetDomainsResponse> GetDomainsAsync(GetDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstance


        /// <summary>
        /// Returns information about a specific Amazon Lightsail instance, which is a virtual
        /// private server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        GetInstanceResponse GetInstance(GetInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceAccessDetails


        /// <summary>
        /// Returns temporary SSH keys you can use to connect to a specific virtual private server,
        /// or <i>instance</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccessDetails service method.</param>
        /// 
        /// <returns>The response from the GetInstanceAccessDetails service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        GetInstanceAccessDetailsResponse GetInstanceAccessDetails(GetInstanceAccessDetailsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceAccessDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccessDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        Task<GetInstanceAccessDetailsResponse> GetInstanceAccessDetailsAsync(GetInstanceAccessDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceMetricData


        /// <summary>
        /// Returns the data points for the specified Amazon Lightsail instance metric, given
        /// an instance name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceMetricData service method.</param>
        /// 
        /// <returns>The response from the GetInstanceMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        GetInstanceMetricDataResponse GetInstanceMetricData(GetInstanceMetricDataRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        Task<GetInstanceMetricDataResponse> GetInstanceMetricDataAsync(GetInstanceMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstancePortStates


        /// <summary>
        /// Returns the port states for a specific virtual private server, or <i>instance</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstancePortStates service method.</param>
        /// 
        /// <returns>The response from the GetInstancePortStates service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        GetInstancePortStatesResponse GetInstancePortStates(GetInstancePortStatesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstancePortStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstancePortStates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        Task<GetInstancePortStatesResponse> GetInstancePortStatesAsync(GetInstancePortStatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstances


        /// <summary>
        /// Returns information about all Amazon Lightsail virtual private servers, or <i>instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstances service method.</param>
        /// 
        /// <returns>The response from the GetInstances service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        GetInstancesResponse GetInstances(GetInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        Task<GetInstancesResponse> GetInstancesAsync(GetInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceSnapshot


        /// <summary>
        /// Returns information about a specific instance snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        GetInstanceSnapshotResponse GetInstanceSnapshot(GetInstanceSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        Task<GetInstanceSnapshotResponse> GetInstanceSnapshotAsync(GetInstanceSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceSnapshots


        /// <summary>
        /// Returns all instance snapshots for the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshots service method.</param>
        /// 
        /// <returns>The response from the GetInstanceSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        GetInstanceSnapshotsResponse GetInstanceSnapshots(GetInstanceSnapshotsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        Task<GetInstanceSnapshotsResponse> GetInstanceSnapshotsAsync(GetInstanceSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceState


        /// <summary>
        /// Returns the state of a specific instance. Works on one instance at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceState service method.</param>
        /// 
        /// <returns>The response from the GetInstanceState service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        GetInstanceStateResponse GetInstanceState(GetInstanceStateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        Task<GetInstanceStateResponse> GetInstanceStateAsync(GetInstanceStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKeyPair


        /// <summary>
        /// Returns information about a specific key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPair service method.</param>
        /// 
        /// <returns>The response from the GetKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        GetKeyPairResponse GetKeyPair(GetKeyPairRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        Task<GetKeyPairResponse> GetKeyPairAsync(GetKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKeyPairs


        /// <summary>
        /// Returns information about all key pairs in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPairs service method.</param>
        /// 
        /// <returns>The response from the GetKeyPairs service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        GetKeyPairsResponse GetKeyPairs(GetKeyPairsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPairs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        Task<GetKeyPairsResponse> GetKeyPairsAsync(GetKeyPairsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperation


        /// <summary>
        /// Returns information about a specific operation. Operations include events such as
        /// when you create an instance, allocate a static IP, attach a static IP, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        GetOperationResponse GetOperation(GetOperationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        Task<GetOperationResponse> GetOperationAsync(GetOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperations


        /// <summary>
        /// Returns information about all operations.
        /// 
        ///  
        /// <para>
        /// Results are returned from oldest to newest, up to a maximum of 200. Results can be
        /// paged by making each subsequent call to <code>GetOperations</code> use the maximum
        /// (last) <code>statusChangedAt</code> value from the previous request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperations service method.</param>
        /// 
        /// <returns>The response from the GetOperations service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        GetOperationsResponse GetOperations(GetOperationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        Task<GetOperationsResponse> GetOperationsAsync(GetOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperationsForResource


        /// <summary>
        /// Gets operations for a specific resource (e.g., an instance or a static IP).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationsForResource service method.</param>
        /// 
        /// <returns>The response from the GetOperationsForResource service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        GetOperationsForResourceResponse GetOperationsForResource(GetOperationsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        Task<GetOperationsForResourceResponse> GetOperationsForResourceAsync(GetOperationsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRegions


        /// <summary>
        /// Returns a list of all valid regions for Amazon Lightsail. Use the <code>include availability
        /// zones</code> parameter to also return the availability zones in a region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegions service method.</param>
        /// 
        /// <returns>The response from the GetRegions service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        GetRegionsResponse GetRegions(GetRegionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        Task<GetRegionsResponse> GetRegionsAsync(GetRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStaticIp


        /// <summary>
        /// Returns information about a specific static IP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIp service method.</param>
        /// 
        /// <returns>The response from the GetStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        GetStaticIpResponse GetStaticIp(GetStaticIpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        Task<GetStaticIpResponse> GetStaticIpAsync(GetStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStaticIps


        /// <summary>
        /// Returns information about all static IPs in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIps service method.</param>
        /// 
        /// <returns>The response from the GetStaticIps service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        GetStaticIpsResponse GetStaticIps(GetStaticIpsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetStaticIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        Task<GetStaticIpsResponse> GetStaticIpsAsync(GetStaticIpsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportKeyPair


        /// <summary>
        /// Imports a public SSH key from a specific key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  IsVpcPeered


        /// <summary>
        /// Returns a Boolean value indicating whether your Lightsail VPC is peered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsVpcPeered service method.</param>
        /// 
        /// <returns>The response from the IsVpcPeered service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        IsVpcPeeredResponse IsVpcPeered(IsVpcPeeredRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the IsVpcPeered operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IsVpcPeered operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        Task<IsVpcPeeredResponse> IsVpcPeeredAsync(IsVpcPeeredRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  OpenInstancePublicPorts


        /// <summary>
        /// Adds public ports to an Amazon Lightsail instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OpenInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the OpenInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        OpenInstancePublicPortsResponse OpenInstancePublicPorts(OpenInstancePublicPortsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the OpenInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OpenInstancePublicPorts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        Task<OpenInstancePublicPortsResponse> OpenInstancePublicPortsAsync(OpenInstancePublicPortsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PeerVpc


        /// <summary>
        /// Tries to peer the Lightsail VPC with the user's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PeerVpc service method.</param>
        /// 
        /// <returns>The response from the PeerVpc service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        PeerVpcResponse PeerVpc(PeerVpcRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PeerVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PeerVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        Task<PeerVpcResponse> PeerVpcAsync(PeerVpcRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutInstancePublicPorts


        /// <summary>
        /// Sets the specified open ports for an Amazon Lightsail instance, and closes all ports
        /// for every protocol not included in the current request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the PutInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        PutInstancePublicPortsResponse PutInstancePublicPorts(PutInstancePublicPortsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInstancePublicPorts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        Task<PutInstancePublicPortsResponse> PutInstancePublicPortsAsync(PutInstancePublicPortsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootInstance


        /// <summary>
        /// Restarts a specific instance. When your Amazon Lightsail instance is finished rebooting,
        /// Lightsail assigns a new public IP address. To use the same IP address after restarting,
        /// create a static IP address and attach it to the instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance service method.</param>
        /// 
        /// <returns>The response from the RebootInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        RebootInstanceResponse RebootInstance(RebootInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReleaseStaticIp


        /// <summary>
        /// Deletes a specific static IP from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseStaticIp service method.</param>
        /// 
        /// <returns>The response from the ReleaseStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        ReleaseStaticIpResponse ReleaseStaticIp(ReleaseStaticIpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        Task<ReleaseStaticIpResponse> ReleaseStaticIpAsync(ReleaseStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartInstance


        /// <summary>
        /// Starts a specific Amazon Lightsail instance from a stopped state. To restart an instance,
        /// use the reboot instance operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstance service method.</param>
        /// 
        /// <returns>The response from the StartInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        StartInstanceResponse StartInstance(StartInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopInstance


        /// <summary>
        /// Stops a specific Amazon Lightsail instance that is currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstance service method.</param>
        /// 
        /// <returns>The response from the StopInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        StopInstanceResponse StopInstance(StopInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnpeerVpc


        /// <summary>
        /// Attempts to unpeer the Lightsail VPC from the user's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnpeerVpc service method.</param>
        /// 
        /// <returns>The response from the UnpeerVpc service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        UnpeerVpcResponse UnpeerVpc(UnpeerVpcRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UnpeerVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnpeerVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        Task<UnpeerVpcResponse> UnpeerVpcAsync(UnpeerVpcRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainEntry


        /// <summary>
        /// Updates a domain recordset after it is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEntry service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        UpdateDomainEntryResponse UpdateDomainEntry(UpdateDomainEntryRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        Task<UpdateDomainEntryResponse> UpdateDomainEntryAsync(UpdateDomainEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}