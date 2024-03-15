import type { Meta } from "@storybook/vue3";
import addCategory from "../addCategory.vue";

const meta: Meta<typeof addCategory> = {
  title: "components/addCategory",
  component: addCategory,
  render: (args) => ({
    components: { addCategory },
    tags: ["autodocs"],
    setup() {
      return { args };
    },
    template: '<addCategory v-bind="args" />',
    parameters: { actions: { argTypesRegex: "^on.*" } }
  })
};

export default meta;

export const Default = {};
