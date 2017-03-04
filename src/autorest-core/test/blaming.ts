import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";

import { createFileUri, resolveUri } from "../lib/approved-imports/uri";
import { parse } from "../lib/approved-imports/jsonpath";
import { DataStore } from "../lib/data-store/dataStore";
import { pipeline } from "../lib/pipeline/pipeline";

@suite class Blaming {
  @test async "end to end blaming with literate swagger"() {
    const dataStore = new DataStore();
    const configFileUri = resolveUri(createFileUri(__dirname) + "/", "resources/literate-example/readme.md");
    const results = await pipeline(configFileUri)(dataStore);

    // regular description
    {
      const blameTree = await dataStore.blame(
        "loader/swagger/compose/swagger.yaml",
        { path: parse("$.securityDefinitions.azure_auth.description") });
      const blameInputs = Array.from(blameTree.blameInputs());
      assert.equal(blameInputs.length, 1);
    }

    // markdown description (blames both the swagger's json path and the markdown source of the description)
    {
      const blameTree = await dataStore.blame(
        "loader/swagger/compose/swagger.yaml",
        { path: parse("$.definitions.SearchServiceListResult.description") });
      const blameInputs = Array.from(blameTree.blameInputs());
      assert.equal(blameInputs.length, 2);
    }
  }
}