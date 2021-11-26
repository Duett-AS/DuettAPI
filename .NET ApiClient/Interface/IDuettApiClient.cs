using Duett.Filter;
using Duett.Model;

namespace Duett.Interface
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.4.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v12.0.0.2))")]
    public partial interface IDuettApiClient
    {
        /// <summary>Deletes an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ArticleDeleteAsync(int id);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Deletes an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ArticleDeleteAsync(int id, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Patches an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to patch.</param>
        /// <param name="body">The operations to perform on ArticleCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ArticlePatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Patches an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to patch.</param>
        /// <param name="body">The operations to perform on ArticleCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ArticlePatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Replaces an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to replace.</param>
        /// <param name="body">The ArticleCreate to replace the old Article from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ArticlePutAsync(int id, ArticleCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Replaces an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to replace.</param>
        /// <param name="body">The ArticleCreate to replace the old Article from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ArticlePutAsync(int id, ArticleCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets all existing Article.</summary>
        /// <param name="extend">A list of keys on which to extend the Article, e.g. HourRegistrations, Metadata.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Article>> ArticleGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets all existing Article.</summary>
        /// <param name="extend">A list of keys on which to extend the Article, e.g. HourRegistrations, Metadata.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Article>> ArticleGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a new Article.</summary>
        /// <param name="body">The ArticleCreate to create a new Article from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Article> ArticlePostAsync(ArticleCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new Article.</summary>
        /// <param name="body">The ArticleCreate to create a new Article from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Article> ArticlePostAsync(ArticleCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Deletes an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierDeleteAsync(int id);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Deletes an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierDeleteAsync(int id, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id to get Carrier for.</param>
        /// <param name="extend">A list of keys on which to extend the Carrier, e.g. HourRegistrations, CarrierType.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Carrier> CarrierGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id to get Carrier for.</param>
        /// <param name="extend">A list of keys on which to extend the Carrier, e.g. HourRegistrations, CarrierType.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Carrier> CarrierGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Patches an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to patch.</param>
        /// <param name="body">The operations to perform on  CarrierCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierPatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Patches an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to patch.</param>
        /// <param name="body">The operations to perform on  CarrierCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierPatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Replaces an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to replace.</param>
        /// <param name="body">The CarrierCreate to create a new Carrier from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierPutAsync(int id, CarrierCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Replaces an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to replace.</param>
        /// <param name="body">The CarrierCreate to create a new Carrier from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierPutAsync(int id, CarrierCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets all existing Carrier.</summary>
        /// <param name="extend">A list of keys on which to extend the Carrier, e.g. HourRegistrations, CarrierType.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Carrier>>CarrierGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets all existing Carrier.</summary>
        /// <param name="extend">A list of keys on which to extend the Carrier, e.g. HourRegistrations, CarrierType.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Carrier>> CarrierGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a new Carrier.</summary>
        /// <param name="body">The CarrierCreate to create a new Carrier from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Carrier> CarrierPostAsync(CarrierCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new Carrier.</summary>
        /// <param name="body">The CarrierCreate to create a new Carrier from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Carrier> CarrierPostAsync(CarrierCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Deletes an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierTypeDeleteAsync(int id);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Deletes an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierTypeDeleteAsync(int id, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id to get CarrierType for.</param>
        /// <param name="extend">A list of keys on which to extend the CarrierType, e.g. Carriers.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CarrierType> CarrierTypeGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id to get CarrierType for.</param>
        /// <param name="extend">A list of keys on which to extend the CarrierType, e.g. Carriers.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CarrierType> CarrierTypeGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Patches an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to patch.</param>
        /// <param name="body">The operations to perform on CarrierTypeCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierTypePatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Patches an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to patch.</param>
        /// <param name="body">The operations to perform on CarrierTypeCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierTypePatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Replaces an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to replace.</param>
        /// <param name="body">The CarrierTypeCreate to create a new CarrierType from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierTypePutAsync(int id, CarrierTypeCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Replaces an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to replace.</param>
        /// <param name="body">The CarrierTypeCreate to create a new CarrierType from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CarrierTypePutAsync(int id, CarrierTypeCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets all existing CarrierType.</summary>
        /// <param name="extend">A list of keys on which to extend the CarrierType, e.g. Carriers.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CarrierType>> CarrierTypeGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets all existing CarrierType.</summary>
        /// <param name="extend">A list of keys on which to extend the CarrierType, e.g. Carriers.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<CarrierType>> CarrierTypeGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a new CarrierType.</summary>
        /// <param name="body">The CarrierTypeCreate to create a new CarrierType of the type CT_Free from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CarrierType> CarrierTypePostAsync(CarrierTypeCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new CarrierType.</summary>
        /// <param name="body">The CarrierTypeCreate to create a new CarrierType of the type CT_Free from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<CarrierType> CarrierTypePostAsync(CarrierTypeCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Deletes an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CustomerDeleteAsync(int id);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Deletes an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CustomerDeleteAsync(int id, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id to get Customer for.</param>
        /// <param name="extend">A list of keys on which to extend the Customer, e.g. Address, ContactInfo, ContactPerson, HourRegistrations.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Customer> CustomerGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id to get Customer for.</param>
        /// <param name="extend">A list of keys on which to extend the Customer, e.g. Address, ContactInfo, ContactPerson, HourRegistrations.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Customer> CustomerGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Patches an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to patch.</param>
        /// <param name="body">The operations to perform on CustomerCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CustomerPatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Patches an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to patch.</param>
        /// <param name="body">The operations to perform on CustomerCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CustomerPatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Replaces an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to replace.</param>
        /// <param name="body">The CustomerCreate to create a new Customer from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CustomerPutAsync(int id, CustomerCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Replaces an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to replace.</param>
        /// <param name="body">The CustomerCreate to create a new Customer from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task CustomerPutAsync(int id, CustomerCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets all existing Customer.</summary>
        /// <param name="extend">A list of keys on which to extend the Customer, e.g. Address, ContactInfo, ContactPerson, HourRegistrations.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Customer>> CustomerGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets all existing Customer.</summary>
        /// <param name="extend">A list of keys on which to extend the Customer, e.g. Address, ContactInfo, ContactPerson, HourRegistrations.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Customer>> CustomerGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a new Customer.</summary>
        /// <param name="body">The CustomerCreate to create a new Customer from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Customer> CustomerPostAsync(CustomerCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new Customer.</summary>
        /// <param name="body">The CustomerCreate to create a new Customer from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Customer> CustomerPostAsync(CustomerCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Deletes an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task HourRegistrationDeleteAsync(int id);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Deletes an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task HourRegistrationDeleteAsync(int id, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id to get HourRegistration for.</param>
        /// <param name="extend">A list of keys on which to extend the HourRegistration, e.g. Article,Customer, Carriers.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<HourRegistration> HourRegistrationGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id to get HourRegistration for.</param>
        /// <param name="extend">A list of keys on which to extend the HourRegistration, e.g. Article,Customer, Carriers.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<HourRegistration> HourRegistrationGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Patches an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to patch.</param>
        /// <param name="body">The operations to perform onHourRegistrationCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task HourRegistrationPatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Patches an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to patch.</param>
        /// <param name="body">The operations to perform onHourRegistrationCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task HourRegistrationPatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Replaces an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to replace.</param>
        /// <param name="body">The HourRegistrationCreate to create a new HourRegistration from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task HourRegistrationPutAsync(int id, HourRegistrationCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Replaces an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to replace.</param>
        /// <param name="body">The HourRegistrationCreate to create a new HourRegistration from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task HourRegistrationPutAsync(int id, HourRegistrationCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets all existing HourRegistration.</summary>
        /// <param name="extend">A list of keys on which to extend the HourRegistration, e.g. Article, Customer.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<HourRegistration>> HourRegistrationGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets all existing HourRegistration.</summary>
        /// <param name="extend">A list of keys on which to extend the HourRegistration, e.g. Article, Customer.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<HourRegistration>> HourRegistrationGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a new HourRegistration.</summary>
        /// <param name="body">The HourRegistrationCreate to create a new HourRegistration from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<HourRegistration> HourRegistrationPostAsync(HourRegistrationCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new HourRegistration.</summary>
        /// <param name="body">The HourRegistrationCreate to create a new HourRegistration from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<HourRegistration> HourRegistrationPostAsync(HourRegistrationCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets an existing HourRegistrationDocument given the specified Id.</summary>
        /// <param name="id">The Id to get HourRegistrationDocument for.</param>
        /// <param name="extend">A list of keys on which to extend the Customer, e.g. Orders (not implemented).</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<HourRegistrationDocument> HourRegistrationDocumentGetAsync(System.Guid id, System.Collections.Generic.IEnumerable<string> extend);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets an existing HourRegistrationDocument given the specified Id.</summary>
        /// <param name="id">The Id to get HourRegistrationDocument for.</param>
        /// <param name="extend">A list of keys on which to extend the Customer, e.g. Orders (not implemented).</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<HourRegistrationDocument> HourRegistrationDocumentGetAsync(System.Guid id, System.Collections.Generic.IEnumerable<string> extend, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a new HourRegistrationDocument.</summary>
        /// <param name="body">The HourRegistrationDocumentCreate to create a new HourRegistrationDocument from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<string> HourRegistrationDocumentPostAsync(HourRegistrationDocumentCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new HourRegistrationDocument.</summary>
        /// <param name="body">The HourRegistrationDocumentCreate to create a new HourRegistrationDocument from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<string> HourRegistrationDocumentPostAsync(HourRegistrationDocumentCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Deletes an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ProjectDeleteAsync(int id);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Deletes an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ProjectDeleteAsync(int id, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets an existing Project given the specified Id.</summary>
        /// <param name="id">The Id to get Project for.</param>
        /// <param name="extend">A list of keys on which to extend the Project.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Project> ProjectGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets an existing Project given the specified Id.</summary>
        /// <param name="id">The Id to get Project for.</param>
        /// <param name="extend">A list of keys on which to extend the Project.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Project> ProjectGetAsync(int id, System.Collections.Generic.IEnumerable<string> extend, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Patches an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to patch.</param>
        /// <param name="body">The operations to perform onProjectCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ProjectPatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Patches an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to patch.</param>
        /// <param name="body">The operations to perform onProjectCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ProjectPatchAsync(int id, System.Collections.Generic.IEnumerable<JsonPatchOperation> body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Replaces an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to replace.</param>
        /// <param name="body">The ProjectCreate to create a new Project from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ProjectPutAsync(int id, ProjectCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Replaces an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to replace.</param>
        /// <param name="body">The ProjectCreate to create a new Project from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ProjectPutAsync(int id, ProjectCreate body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Gets all existing Project.</summary>
        /// <param name="extend">A list of keys on which to extend the Project.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Project>> ProjectGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Gets all existing Project.</summary>
        /// <param name="extend">A list of keys on which to extend the Project.</param>
        /// <param name="filter">Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Project>> ProjectGetAllAsync(System.Collections.Generic.IEnumerable<string> extend, FilterAction filter, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a new Project.</summary>
        /// <param name="body">The ProjectCreate to create a new Project from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Project> ProjectPostAsync(ProjectCreate body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new Project.</summary>
        /// <param name="body">The ProjectCreate to create a new Project from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Project> ProjectPostAsync(ProjectCreate body, System.Threading.CancellationToken cancellationToken);
    
    }
}