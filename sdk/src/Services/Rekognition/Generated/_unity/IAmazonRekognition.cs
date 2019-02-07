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

using Amazon.Runtime;
using Amazon.Rekognition.Model;

namespace Amazon.Rekognition
{
    /// <summary>
    /// Interface for accessing Rekognition
    ///
    /// This is the Amazon Rekognition API reference.
    /// </summary>
    public partial interface IAmazonRekognition : IAmazonService, IDisposable
    {
                
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
        void CompareFacesAsync(CompareFacesRequest request, AmazonServiceCallback<CompareFacesRequest, CompareFacesResponse> callback, AsyncOptions options = null);

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
        void CreateCollectionAsync(CreateCollectionRequest request, AmazonServiceCallback<CreateCollectionRequest,CreateCollectionResponse> callback, AsyncOptions options = null);

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
        void CreateStreamProcessorAsync(CreateStreamProcessorRequest request, AmazonServiceCallback<CreateStreamProcessorRequest, CreateStreamProcessorResponse> callback, AsyncOptions options = null);

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
        void DeleteCollectionAsync(DeleteCollectionRequest request, AmazonServiceCallback<DeleteCollectionRequest, DeleteCollectionResponse> callback, AsyncOptions options = null);

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
        void DeleteFacesAsync(DeleteFacesRequest request, AmazonServiceCallback<DeleteFacesRequest, DeleteFacesResponse> callback, AsyncOptions options = null);

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
        void DeleteStreamProcessorAsync(DeleteStreamProcessorRequest request, AmazonServiceCallback<DeleteStreamProcessorRequest, DeleteStreamProcessorResponse> callback, AsyncOptions options = null);

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
        void DescribeCollectionAsync(DescribeCollectionRequest request, AmazonServiceCallback<DescribeCollectionRequest, DescribeCollectionResponse> callback, AsyncOptions options = null);

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
        void DescribeStreamProcessorAsync(DescribeStreamProcessorRequest request, AmazonServiceCallback<DescribeStreamProcessorRequest, DescribeStreamProcessorResponse> callback, AsyncOptions options = null);

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
        void DetectFacesAsync(DetectFacesRequest request, AmazonServiceCallback<DetectFacesRequest, DetectFacesResponse> callback, AsyncOptions options = null);

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
        void DetectLabelsAsync(DetectLabelsRequest request, AmazonServiceCallback<DetectLabelsRequest, DetectLabelsResponse> callback, AsyncOptions options = null);

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
        void DetectModerationLabelsAsync(DetectModerationLabelsRequest request, AmazonServiceCallback<DetectModerationLabelsRequest, DetectModerationLabelsResponse> callback, AsyncOptions options = null);

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
        void DetectTextAsync(DetectTextRequest request, AmazonServiceCallback<DetectTextRequest, DetectTextResponse> callback, AsyncOptions options = null);

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
        void GetCelebrityInfoAsync(GetCelebrityInfoRequest request, AmazonServiceCallback<GetCelebrityInfoRequest, GetCelebrityInfoResponse> callback, AsyncOptions options = null);

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
        void GetCelebrityRecognitionAsync(GetCelebrityRecognitionRequest request, AmazonServiceCallback<GetCelebrityRecognitionRequest, GetCelebrityRecognitionResponse> callback, AsyncOptions options = null);

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
        void GetContentModerationAsync(GetContentModerationRequest request, AmazonServiceCallback<GetContentModerationRequest, GetContentModerationResponse> callback, AsyncOptions options = null);

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
        void GetFaceDetectionAsync(GetFaceDetectionRequest request, AmazonServiceCallback<GetFaceDetectionRequest, GetFaceDetectionResponse> callback, AsyncOptions options = null);

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
        void GetFaceSearchAsync(GetFaceSearchRequest request, AmazonServiceCallback<GetFaceSearchRequest, GetFaceSearchResponse> callback, AsyncOptions options = null);

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
        void GetLabelDetectionAsync(GetLabelDetectionRequest request, AmazonServiceCallback<GetLabelDetectionRequest, GetLabelDetectionResponse> callback, AsyncOptions options = null);

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
        void GetPersonTrackingAsync(GetPersonTrackingRequest request, AmazonServiceCallback<GetPersonTrackingRequest, GetPersonTrackingResponse> callback, AsyncOptions options = null);

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
        void IndexFacesAsync(IndexFacesRequest request, AmazonServiceCallback<IndexFacesRequest, IndexFacesResponse> callback, AsyncOptions options = null);

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
        void ListCollectionsAsync(ListCollectionsRequest request, AmazonServiceCallback<ListCollectionsRequest, ListCollectionsResponse> callback, AsyncOptions options = null);

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
        void ListFacesAsync(ListFacesRequest request, AmazonServiceCallback<ListFacesRequest, ListFacesResponse> callback, AsyncOptions options = null);

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
        void ListStreamProcessorsAsync(ListStreamProcessorsRequest request, AmazonServiceCallback<ListStreamProcessorsRequest, ListStreamProcessorsResponse> callback, AsyncOptions options = null);

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
        void RecognizeCelebritiesAsync(RecognizeCelebritiesRequest request, AmazonServiceCallback<RecognizeCelebritiesRequest, RecognizeCelebritiesResponse> callback, AsyncOptions options = null);

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
        void SearchFacesAsync(SearchFacesRequest request, AmazonServiceCallback<SearchFacesRequest, SearchFacesResponse> callback, AsyncOptions options = null);

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
        void SearchFacesByImageAsync(SearchFacesByImageRequest request, AmazonServiceCallback<SearchFacesByImageRequest, SearchFacesByImageResponse> callback, AsyncOptions options = null);

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
        void StartCelebrityRecognitionAsync(StartCelebrityRecognitionRequest request, AmazonServiceCallback<StartCelebrityRecognitionRequest, StartCelebrityRecognitionResponse> callback, AsyncOptions options = null);

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
        void StartContentModerationAsync(StartContentModerationRequest request, AmazonServiceCallback<StartContentModerationRequest, StartContentModerationResponse> callback, AsyncOptions options = null);

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
        void StartFaceDetectionAsync(StartFaceDetectionRequest request, AmazonServiceCallback<StartFaceDetectionRequest, StartFaceDetectionResponse> callback, AsyncOptions options = null);

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
        void StartFaceSearchAsync(StartFaceSearchRequest request, AmazonServiceCallback<StartFaceSearchRequest, StartFaceSearchResponse> callback, AsyncOptions options = null);

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
        void StartLabelDetectionAsync(StartLabelDetectionRequest request, AmazonServiceCallback<StartLabelDetectionRequest, StartLabelDetectionResponse> callback, AsyncOptions options = null);

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
        void StartPersonTrackingAsync(StartPersonTrackingRequest request, AmazonServiceCallback<StartPersonTrackingRequest, StartPersonTrackingResponse> callback, AsyncOptions options = null);

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
        void StartStreamProcessorAsync(StartStreamProcessorRequest request, AmazonServiceCallback<StartStreamProcessorRequest, StartStreamProcessorResponse> callback, AsyncOptions options = null);

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
        void StopStreamProcessorAsync(StopStreamProcessorRequest request, AmazonServiceCallback<StopStreamProcessorRequest, StopStreamProcessorResponse> callback, AsyncOptions options = null);

        #endregion
        
    }
}