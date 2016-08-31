/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodyinteger;

import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import fixtures.bodyinteger.models.ErrorException;
import java.io.IOException;
import org.joda.time.DateTime;
import rx.Observable;

/**
 * An instance of this class provides access to all the operations defined
 * in Ints.
 */
public interface Ints {
    /**
     * Get null Int value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the int object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Integer> getNull() throws ErrorException, IOException;

    /**
     * Get null Int value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Integer> getNullAsync(final ServiceCallback<Integer> serviceCallback);

    /**
     * Get null Int value.
     *
     * @return the observable to the int object
     */
    Observable<ServiceResponse<Integer>> getNullAsync();

    /**
     * Get invalid Int value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the int object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Integer> getInvalid() throws ErrorException, IOException;

    /**
     * Get invalid Int value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Integer> getInvalidAsync(final ServiceCallback<Integer> serviceCallback);

    /**
     * Get invalid Int value.
     *
     * @return the observable to the int object
     */
    Observable<ServiceResponse<Integer>> getInvalidAsync();

    /**
     * Get overflow Int32 value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the int object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Integer> getOverflowInt32() throws ErrorException, IOException;

    /**
     * Get overflow Int32 value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Integer> getOverflowInt32Async(final ServiceCallback<Integer> serviceCallback);

    /**
     * Get overflow Int32 value.
     *
     * @return the observable to the int object
     */
    Observable<ServiceResponse<Integer>> getOverflowInt32Async();

    /**
     * Get underflow Int32 value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the int object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Integer> getUnderflowInt32() throws ErrorException, IOException;

    /**
     * Get underflow Int32 value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Integer> getUnderflowInt32Async(final ServiceCallback<Integer> serviceCallback);

    /**
     * Get underflow Int32 value.
     *
     * @return the observable to the int object
     */
    Observable<ServiceResponse<Integer>> getUnderflowInt32Async();

    /**
     * Get overflow Int64 value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the long object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Long> getOverflowInt64() throws ErrorException, IOException;

    /**
     * Get overflow Int64 value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Long> getOverflowInt64Async(final ServiceCallback<Long> serviceCallback);

    /**
     * Get overflow Int64 value.
     *
     * @return the observable to the long object
     */
    Observable<ServiceResponse<Long>> getOverflowInt64Async();

    /**
     * Get underflow Int64 value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the long object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<Long> getUnderflowInt64() throws ErrorException, IOException;

    /**
     * Get underflow Int64 value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Long> getUnderflowInt64Async(final ServiceCallback<Long> serviceCallback);

    /**
     * Get underflow Int64 value.
     *
     * @return the observable to the long object
     */
    Observable<ServiceResponse<Long>> getUnderflowInt64Async();

    /**
     * Put max int32 value.
     *
     * @param intBody the int value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putMax32(int intBody) throws ErrorException, IOException;

    /**
     * Put max int32 value.
     *
     * @param intBody the int value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Void> putMax32Async(int intBody, final ServiceCallback<Void> serviceCallback);

    /**
     * Put max int32 value.
     *
     * @param intBody the int value
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<ServiceResponse<Void>> putMax32Async(int intBody);

    /**
     * Put max int64 value.
     *
     * @param intBody the long value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putMax64(long intBody) throws ErrorException, IOException;

    /**
     * Put max int64 value.
     *
     * @param intBody the long value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Void> putMax64Async(long intBody, final ServiceCallback<Void> serviceCallback);

    /**
     * Put max int64 value.
     *
     * @param intBody the long value
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<ServiceResponse<Void>> putMax64Async(long intBody);

    /**
     * Put min int32 value.
     *
     * @param intBody the int value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putMin32(int intBody) throws ErrorException, IOException;

    /**
     * Put min int32 value.
     *
     * @param intBody the int value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Void> putMin32Async(int intBody, final ServiceCallback<Void> serviceCallback);

    /**
     * Put min int32 value.
     *
     * @param intBody the int value
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<ServiceResponse<Void>> putMin32Async(int intBody);

    /**
     * Put min int64 value.
     *
     * @param intBody the long value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putMin64(long intBody) throws ErrorException, IOException;

    /**
     * Put min int64 value.
     *
     * @param intBody the long value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Void> putMin64Async(long intBody, final ServiceCallback<Void> serviceCallback);

    /**
     * Put min int64 value.
     *
     * @param intBody the long value
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<ServiceResponse<Void>> putMin64Async(long intBody);

    /**
     * Get datetime encoded as Unix time value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the DateTime object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<DateTime> getUnixTime() throws ErrorException, IOException;

    /**
     * Get datetime encoded as Unix time value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<DateTime> getUnixTimeAsync(final ServiceCallback<DateTime> serviceCallback);

    /**
     * Get datetime encoded as Unix time value.
     *
     * @return the observable to the DateTime object
     */
    Observable<ServiceResponse<DateTime>> getUnixTimeAsync();

    /**
     * Put datetime encoded as Unix time.
     *
     * @param intBody the long value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> putUnixTimeDate(DateTime intBody) throws ErrorException, IOException;

    /**
     * Put datetime encoded as Unix time.
     *
     * @param intBody the long value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Void> putUnixTimeDateAsync(DateTime intBody, final ServiceCallback<Void> serviceCallback);

    /**
     * Put datetime encoded as Unix time.
     *
     * @param intBody the long value
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<ServiceResponse<Void>> putUnixTimeDateAsync(DateTime intBody);

    /**
     * Get invalid Unix time value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the DateTime object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<DateTime> getInvalidUnixTime() throws ErrorException, IOException;

    /**
     * Get invalid Unix time value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<DateTime> getInvalidUnixTimeAsync(final ServiceCallback<DateTime> serviceCallback);

    /**
     * Get invalid Unix time value.
     *
     * @return the observable to the DateTime object
     */
    Observable<ServiceResponse<DateTime>> getInvalidUnixTimeAsync();

    /**
     * Get null Unix time value.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the DateTime object wrapped in {@link ServiceResponse} if successful.
     */
    ServiceResponse<DateTime> getNullUnixTime() throws ErrorException, IOException;

    /**
     * Get null Unix time value.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<DateTime> getNullUnixTimeAsync(final ServiceCallback<DateTime> serviceCallback);

    /**
     * Get null Unix time value.
     *
     * @return the observable to the DateTime object
     */
    Observable<ServiceResponse<DateTime>> getNullUnixTimeAsync();

}
