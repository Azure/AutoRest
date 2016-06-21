# encoding: utf-8

$: << 'RspecTests/Generated/validation'

require 'rspec'
require 'validation'

describe 'Validation Module' do

  before(:all) do
    @base_url = ENV['StubServerURI']

    dummyToken = 'dummy12321343423'
    @credentials = MsRest::TokenCredentials.new(dummyToken)

    @client = ValidationModule::AutoRestValidationTest.new(@credentials, @base_url)
  end

  it 'should works with constant in path' do
    result = @client.get_with_constant_in_path_async().value!
    expect(result.response.status).to eq(200)
  end

  it 'should works with constant in body' do
    product = ValidationModule::Models::Product.new
    product.child = Hash.new
    result = @client.post_with_constant_in_body_async({ 'child' => {} }).value!
    expect(result.response.status).to eq(200)
  end
end