/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Test
{
    /// <summary>
    ///  Class for testing PackagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PackagesApiTests
    {
        private PackagesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PackagesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PackagesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PackagesApi
            //Assert.IsInstanceOfType(typeof(PackagesApi), instance, "instance is a PackagesApi");
        }

        
        /// <summary>
        /// Test PackagesCreate
        /// </summary>
        [Test]
        public void PackagesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Package package = null;
            //string apiKey = null;
            //var response = instance.PackagesCreate(package, apiKey);
            //Assert.IsInstanceOf<Package> (response, "response is Package");
        }
        
        /// <summary>
        /// Test PackagesDelete
        /// </summary>
        [Test]
        public void PackagesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string packageId = null;
            //string apiKey = null;
            //instance.PackagesDelete(packageId, apiKey);
            
        }
        
        /// <summary>
        /// Test PackagesGet
        /// </summary>
        [Test]
        public void PackagesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string packageId = null;
            //string apiKey = null;
            //var response = instance.PackagesGet(packageId, apiKey);
            //Assert.IsInstanceOf<Package> (response, "response is Package");
        }
        
        /// <summary>
        /// Test PackagesList
        /// </summary>
        [Test]
        public void PackagesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //var response = instance.PackagesList(apiKey);
            //Assert.IsInstanceOf<PackagesListResponse> (response, "response is PackagesListResponse");
        }
        
        /// <summary>
        /// Test PackagesUpdate
        /// </summary>
        [Test]
        public void PackagesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string packageId = null;
            //Package package = null;
            //string apiKey = null;
            //instance.PackagesUpdate(packageId, package, apiKey);
            
        }
        
    }

}
