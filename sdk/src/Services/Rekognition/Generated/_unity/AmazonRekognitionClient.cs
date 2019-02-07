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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Rekognition.Model;
using Amazon.Rekognition.Model.Internal.MarshallTransformations;
using Amazon.Rekognition.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Rekognition
{
    /// <summary>
    /// Implementation for accessing Rekognition
    ///
    /// This is the Amazon Rekognition API reference.
    /// </summary>
    public partial class AmazonRekognitionClient : AmazonServiceClient, IAmazonRekognition
    {
        private static IServiceMetadata serviceMetadata = new AmazonRekognitionMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRekognitionClient(AWSCredentials credentials)
            : this(credentials, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRekognitionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials and an
        /// AmazonRekognitionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(AWSCredentials credentials, AmazonRekognitionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRekognitionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRekognitionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRekognitionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRekognitionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRekognitionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRekognitionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CompareFaces

        /// <summary>
        /// Initiates the asynchronous execution of the CompareFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompareFaces operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        public virtual void CompareFacesAsync(CompareFacesRequest request, AmazonServiceCallback<CompareFacesRequest, CompareFacesResponse> callback, AsyncOptions options)
        {
            options = options == null?new AsyncOptions():options;

            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CompareFacesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CompareFacesResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CompareFacesRequest,CompareFacesResponse> responseObject 
                            = new AmazonServiceResult<CompareFacesRequest,CompareFacesResponse>((CompareFacesRequest)req, (CompareFacesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateCollection

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public virtual void CreateCollectionAsync(CreateCollectionRequest request, AmazonServiceCallback<CreateCollectionRequest, CreateCollectionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateCollectionRequest,CreateCollectionResponse> responseObject 
                            = new AmazonServiceResult<CreateCollectionRequest,CreateCollectionResponse>((CreateCollectionRequest)req, (CreateCollectionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateStreamProcessor

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamProcessor operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateStreamProcessor">REST API Reference for CreateStreamProcessor Operation</seealso>
        public virtual void CreateStreamProcessorAsync(CreateStreamProcessorRequest request, AmazonServiceCallback<CreateStreamProcessorRequest, CreateStreamProcessorResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateStreamProcessorRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateStreamProcessorRequest,CreateStreamProcessorResponse> responseObject 
                            = new AmazonServiceResult<CreateStreamProcessorRequest,CreateStreamProcessorResponse>((CreateStreamProcessorRequest)req, (CreateStreamProcessorResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteCollection

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual void DeleteCollectionAsync(DeleteCollectionRequest request, AmazonServiceCallback<DeleteCollectionRequest, DeleteCollectionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteCollectionRequest,DeleteCollectionResponse> responseObject 
                            = new AmazonServiceResult<DeleteCollectionRequest,DeleteCollectionResponse>((DeleteCollectionRequest)req, (DeleteCollectionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteFaces

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaces operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        public virtual void DeleteFacesAsync(DeleteFacesRequest request, AmazonServiceCallback<DeleteFacesRequest, DeleteFacesResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteFacesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteFacesRequest,DeleteFacesResponse> responseObject 
                            = new AmazonServiceResult<DeleteFacesRequest,DeleteFacesResponse>((DeleteFacesRequest)req, (DeleteFacesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteStreamProcessor

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamProcessor operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteStreamProcessor">REST API Reference for DeleteStreamProcessor Operation</seealso>
        public virtual void DeleteStreamProcessorAsync(DeleteStreamProcessorRequest request, AmazonServiceCallback<DeleteStreamProcessorRequest, DeleteStreamProcessorResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteStreamProcessorRequest,DeleteStreamProcessorResponse> responseObject 
                            = new AmazonServiceResult<DeleteStreamProcessorRequest,DeleteStreamProcessorResponse>((DeleteStreamProcessorRequest)req, (DeleteStreamProcessorResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeCollection

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCollection operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeCollection">REST API Reference for DescribeCollection Operation</seealso>
        public virtual void DescribeCollectionAsync(DescribeCollectionRequest request, AmazonServiceCallback<DescribeCollectionRequest, DescribeCollectionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeCollectionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeCollectionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeCollectionRequest,DescribeCollectionResponse> responseObject 
                            = new AmazonServiceResult<DescribeCollectionRequest,DescribeCollectionResponse>((DescribeCollectionRequest)req, (DescribeCollectionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeStreamProcessor

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamProcessor operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeStreamProcessor">REST API Reference for DescribeStreamProcessor Operation</seealso>
        public virtual void DescribeStreamProcessorAsync(DescribeStreamProcessorRequest request, AmazonServiceCallback<DescribeStreamProcessorRequest, DescribeStreamProcessorResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeStreamProcessorRequest,DescribeStreamProcessorResponse> responseObject 
                            = new AmazonServiceResult<DescribeStreamProcessorRequest,DescribeStreamProcessorResponse>((DescribeStreamProcessorRequest)req, (DescribeStreamProcessorResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DetectFaces

        /// <summary>
        /// Initiates the asynchronous execution of the DetectFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectFaces operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        public virtual void DetectFacesAsync(DetectFacesRequest request, AmazonServiceCallback<DetectFacesRequest, DetectFacesResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DetectFacesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DetectFacesResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DetectFacesRequest,DetectFacesResponse> responseObject 
                            = new AmazonServiceResult<DetectFacesRequest,DetectFacesResponse>((DetectFacesRequest)req, (DetectFacesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DetectLabels

        /// <summary>
        /// Initiates the asynchronous execution of the DetectLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectLabels operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        public virtual void DetectLabelsAsync(DetectLabelsRequest request, AmazonServiceCallback<DetectLabelsRequest, DetectLabelsResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DetectLabelsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DetectLabelsRequest,DetectLabelsResponse> responseObject 
                            = new AmazonServiceResult<DetectLabelsRequest,DetectLabelsResponse>((DetectLabelsRequest)req, (DetectLabelsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DetectModerationLabels

        /// <summary>
        /// Initiates the asynchronous execution of the DetectModerationLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectModerationLabels operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        public virtual void DetectModerationLabelsAsync(DetectModerationLabelsRequest request, AmazonServiceCallback<DetectModerationLabelsRequest, DetectModerationLabelsResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DetectModerationLabelsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DetectModerationLabelsRequest,DetectModerationLabelsResponse> responseObject 
                            = new AmazonServiceResult<DetectModerationLabelsRequest,DetectModerationLabelsResponse>((DetectModerationLabelsRequest)req, (DetectModerationLabelsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DetectText

        /// <summary>
        /// Initiates the asynchronous execution of the DetectText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectText operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectText">REST API Reference for DetectText Operation</seealso>
        public virtual void DetectTextAsync(DetectTextRequest request, AmazonServiceCallback<DetectTextRequest, DetectTextResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DetectTextRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DetectTextResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DetectTextRequest,DetectTextResponse> responseObject 
                            = new AmazonServiceResult<DetectTextRequest,DetectTextResponse>((DetectTextRequest)req, (DetectTextResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetCelebrityInfo

        /// <summary>
        /// Initiates the asynchronous execution of the GetCelebrityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityInfo operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        public virtual void GetCelebrityInfoAsync(GetCelebrityInfoRequest request, AmazonServiceCallback<GetCelebrityInfoRequest, GetCelebrityInfoResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetCelebrityInfoRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetCelebrityInfoRequest,GetCelebrityInfoResponse> responseObject 
                            = new AmazonServiceResult<GetCelebrityInfoRequest,GetCelebrityInfoResponse>((GetCelebrityInfoRequest)req, (GetCelebrityInfoResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetCelebrityRecognition

        /// <summary>
        /// Initiates the asynchronous execution of the GetCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityRecognition operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityRecognition">REST API Reference for GetCelebrityRecognition Operation</seealso>
        public virtual void GetCelebrityRecognitionAsync(GetCelebrityRecognitionRequest request, AmazonServiceCallback<GetCelebrityRecognitionRequest, GetCelebrityRecognitionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetCelebrityRecognitionRequest,GetCelebrityRecognitionResponse> responseObject 
                            = new AmazonServiceResult<GetCelebrityRecognitionRequest,GetCelebrityRecognitionResponse>((GetCelebrityRecognitionRequest)req, (GetCelebrityRecognitionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetContentModeration

        /// <summary>
        /// Initiates the asynchronous execution of the GetContentModeration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentModeration operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetContentModeration">REST API Reference for GetContentModeration Operation</seealso>
        public virtual void GetContentModerationAsync(GetContentModerationRequest request, AmazonServiceCallback<GetContentModerationRequest, GetContentModerationResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetContentModerationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetContentModerationRequest,GetContentModerationResponse> responseObject 
                            = new AmazonServiceResult<GetContentModerationRequest,GetContentModerationResponse>((GetContentModerationRequest)req, (GetContentModerationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetFaceDetection

        /// <summary>
        /// Initiates the asynchronous execution of the GetFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFaceDetection operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceDetection">REST API Reference for GetFaceDetection Operation</seealso>
        public virtual void GetFaceDetectionAsync(GetFaceDetectionRequest request, AmazonServiceCallback<GetFaceDetectionRequest, GetFaceDetectionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetFaceDetectionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetFaceDetectionRequest,GetFaceDetectionResponse> responseObject 
                            = new AmazonServiceResult<GetFaceDetectionRequest,GetFaceDetectionResponse>((GetFaceDetectionRequest)req, (GetFaceDetectionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetFaceSearch

        /// <summary>
        /// Initiates the asynchronous execution of the GetFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFaceSearch operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceSearch">REST API Reference for GetFaceSearch Operation</seealso>
        public virtual void GetFaceSearchAsync(GetFaceSearchRequest request, AmazonServiceCallback<GetFaceSearchRequest, GetFaceSearchResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetFaceSearchRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetFaceSearchRequest,GetFaceSearchResponse> responseObject 
                            = new AmazonServiceResult<GetFaceSearchRequest,GetFaceSearchResponse>((GetFaceSearchRequest)req, (GetFaceSearchResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetLabelDetection

        /// <summary>
        /// Initiates the asynchronous execution of the GetLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLabelDetection operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetLabelDetection">REST API Reference for GetLabelDetection Operation</seealso>
        public virtual void GetLabelDetectionAsync(GetLabelDetectionRequest request, AmazonServiceCallback<GetLabelDetectionRequest, GetLabelDetectionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetLabelDetectionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetLabelDetectionRequest,GetLabelDetectionResponse> responseObject 
                            = new AmazonServiceResult<GetLabelDetectionRequest,GetLabelDetectionResponse>((GetLabelDetectionRequest)req, (GetLabelDetectionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetPersonTracking

        /// <summary>
        /// Initiates the asynchronous execution of the GetPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPersonTracking operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetPersonTracking">REST API Reference for GetPersonTracking Operation</seealso>
        public virtual void GetPersonTrackingAsync(GetPersonTrackingRequest request, AmazonServiceCallback<GetPersonTrackingRequest, GetPersonTrackingResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetPersonTrackingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetPersonTrackingRequest,GetPersonTrackingResponse> responseObject 
                            = new AmazonServiceResult<GetPersonTrackingRequest,GetPersonTrackingResponse>((GetPersonTrackingRequest)req, (GetPersonTrackingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  IndexFaces

        /// <summary>
        /// Initiates the asynchronous execution of the IndexFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexFaces operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        public virtual void IndexFacesAsync(IndexFacesRequest request, AmazonServiceCallback<IndexFacesRequest, IndexFacesResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = IndexFacesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = IndexFacesResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<IndexFacesRequest,IndexFacesResponse> responseObject 
                            = new AmazonServiceResult<IndexFacesRequest,IndexFacesResponse>((IndexFacesRequest)req, (IndexFacesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListCollections

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollections operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual void ListCollectionsAsync(ListCollectionsRequest request, AmazonServiceCallback<ListCollectionsRequest, ListCollectionsResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListCollectionsRequest,ListCollectionsResponse> responseObject 
                            = new AmazonServiceResult<ListCollectionsRequest,ListCollectionsResponse>((ListCollectionsRequest)req, (ListCollectionsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListFaces

        /// <summary>
        /// Initiates the asynchronous execution of the ListFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFaces operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        public virtual void ListFacesAsync(ListFacesRequest request, AmazonServiceCallback<ListFacesRequest, ListFacesResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListFacesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListFacesResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListFacesRequest,ListFacesResponse> responseObject 
                            = new AmazonServiceResult<ListFacesRequest,ListFacesResponse>((ListFacesRequest)req, (ListFacesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListStreamProcessors

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamProcessors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamProcessors operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListStreamProcessors">REST API Reference for ListStreamProcessors Operation</seealso>
        public virtual void ListStreamProcessorsAsync(ListStreamProcessorsRequest request, AmazonServiceCallback<ListStreamProcessorsRequest, ListStreamProcessorsResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListStreamProcessorsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListStreamProcessorsRequest,ListStreamProcessorsResponse> responseObject 
                            = new AmazonServiceResult<ListStreamProcessorsRequest,ListStreamProcessorsResponse>((ListStreamProcessorsRequest)req, (ListStreamProcessorsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  RecognizeCelebrities

        /// <summary>
        /// Initiates the asynchronous execution of the RecognizeCelebrities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecognizeCelebrities operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        public virtual void RecognizeCelebritiesAsync(RecognizeCelebritiesRequest request, AmazonServiceCallback<RecognizeCelebritiesRequest, RecognizeCelebritiesResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RecognizeCelebritiesRequest,RecognizeCelebritiesResponse> responseObject 
                            = new AmazonServiceResult<RecognizeCelebritiesRequest,RecognizeCelebritiesResponse>((RecognizeCelebritiesRequest)req, (RecognizeCelebritiesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SearchFaces

        /// <summary>
        /// Initiates the asynchronous execution of the SearchFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFaces operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        public virtual void SearchFacesAsync(SearchFacesRequest request, AmazonServiceCallback<SearchFacesRequest, SearchFacesResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SearchFacesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SearchFacesResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SearchFacesRequest,SearchFacesResponse> responseObject 
                            = new AmazonServiceResult<SearchFacesRequest,SearchFacesResponse>((SearchFacesRequest)req, (SearchFacesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SearchFacesByImage

        /// <summary>
        /// Initiates the asynchronous execution of the SearchFacesByImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFacesByImage operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        public virtual void SearchFacesByImageAsync(SearchFacesByImageRequest request, AmazonServiceCallback<SearchFacesByImageRequest, SearchFacesByImageResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SearchFacesByImageRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SearchFacesByImageRequest,SearchFacesByImageResponse> responseObject 
                            = new AmazonServiceResult<SearchFacesByImageRequest,SearchFacesByImageResponse>((SearchFacesByImageRequest)req, (SearchFacesByImageResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StartCelebrityRecognition

        /// <summary>
        /// Initiates the asynchronous execution of the StartCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCelebrityRecognition operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartCelebrityRecognition">REST API Reference for StartCelebrityRecognition Operation</seealso>
        public virtual void StartCelebrityRecognitionAsync(StartCelebrityRecognitionRequest request, AmazonServiceCallback<StartCelebrityRecognitionRequest, StartCelebrityRecognitionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartCelebrityRecognitionRequest,StartCelebrityRecognitionResponse> responseObject 
                            = new AmazonServiceResult<StartCelebrityRecognitionRequest,StartCelebrityRecognitionResponse>((StartCelebrityRecognitionRequest)req, (StartCelebrityRecognitionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StartContentModeration

        /// <summary>
        /// Initiates the asynchronous execution of the StartContentModeration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContentModeration operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartContentModeration">REST API Reference for StartContentModeration Operation</seealso>
        public virtual void StartContentModerationAsync(StartContentModerationRequest request, AmazonServiceCallback<StartContentModerationRequest, StartContentModerationResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StartContentModerationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartContentModerationRequest,StartContentModerationResponse> responseObject 
                            = new AmazonServiceResult<StartContentModerationRequest,StartContentModerationResponse>((StartContentModerationRequest)req, (StartContentModerationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StartFaceDetection

        /// <summary>
        /// Initiates the asynchronous execution of the StartFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFaceDetection operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceDetection">REST API Reference for StartFaceDetection Operation</seealso>
        public virtual void StartFaceDetectionAsync(StartFaceDetectionRequest request, AmazonServiceCallback<StartFaceDetectionRequest, StartFaceDetectionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StartFaceDetectionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartFaceDetectionRequest,StartFaceDetectionResponse> responseObject 
                            = new AmazonServiceResult<StartFaceDetectionRequest,StartFaceDetectionResponse>((StartFaceDetectionRequest)req, (StartFaceDetectionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StartFaceSearch

        /// <summary>
        /// Initiates the asynchronous execution of the StartFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFaceSearch operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceSearch">REST API Reference for StartFaceSearch Operation</seealso>
        public virtual void StartFaceSearchAsync(StartFaceSearchRequest request, AmazonServiceCallback<StartFaceSearchRequest, StartFaceSearchResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StartFaceSearchRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartFaceSearchRequest,StartFaceSearchResponse> responseObject 
                            = new AmazonServiceResult<StartFaceSearchRequest,StartFaceSearchResponse>((StartFaceSearchRequest)req, (StartFaceSearchResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StartLabelDetection

        /// <summary>
        /// Initiates the asynchronous execution of the StartLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLabelDetection operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartLabelDetection">REST API Reference for StartLabelDetection Operation</seealso>
        public virtual void StartLabelDetectionAsync(StartLabelDetectionRequest request, AmazonServiceCallback<StartLabelDetectionRequest, StartLabelDetectionResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StartLabelDetectionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartLabelDetectionRequest,StartLabelDetectionResponse> responseObject 
                            = new AmazonServiceResult<StartLabelDetectionRequest,StartLabelDetectionResponse>((StartLabelDetectionRequest)req, (StartLabelDetectionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StartPersonTracking

        /// <summary>
        /// Initiates the asynchronous execution of the StartPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPersonTracking operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartPersonTracking">REST API Reference for StartPersonTracking Operation</seealso>
        public virtual void StartPersonTrackingAsync(StartPersonTrackingRequest request, AmazonServiceCallback<StartPersonTrackingRequest, StartPersonTrackingResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StartPersonTrackingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartPersonTrackingRequest,StartPersonTrackingResponse> responseObject 
                            = new AmazonServiceResult<StartPersonTrackingRequest,StartPersonTrackingResponse>((StartPersonTrackingRequest)req, (StartPersonTrackingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StartStreamProcessor

        /// <summary>
        /// Initiates the asynchronous execution of the StartStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStreamProcessor operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartStreamProcessor">REST API Reference for StartStreamProcessor Operation</seealso>
        public virtual void StartStreamProcessorAsync(StartStreamProcessorRequest request, AmazonServiceCallback<StartStreamProcessorRequest, StartStreamProcessorResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StartStreamProcessorRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartStreamProcessorRequest,StartStreamProcessorResponse> responseObject 
                            = new AmazonServiceResult<StartStreamProcessorRequest,StartStreamProcessorResponse>((StartStreamProcessorRequest)req, (StartStreamProcessorResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StopStreamProcessor

        /// <summary>
        /// Initiates the asynchronous execution of the StopStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStreamProcessor operation.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopStreamProcessor">REST API Reference for StopStreamProcessor Operation</seealso>
        public virtual void StopStreamProcessorAsync(StopStreamProcessorRequest request, AmazonServiceCallback<StopStreamProcessorRequest, StopStreamProcessorResponse> callback, AsyncOptions options)
        {
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StopStreamProcessorRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StopStreamProcessorRequest,StopStreamProcessorResponse> responseObject 
                            = new AmazonServiceResult<StopStreamProcessorRequest,StopStreamProcessorResponse>((StopStreamProcessorRequest)req, (StopStreamProcessorResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
    }
}