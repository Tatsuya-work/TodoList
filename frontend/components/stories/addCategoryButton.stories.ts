import type { Meta } from "@storybook/vue3";
import addCategoryButton from "../addCategoryButton.vue";

const meta: Meta<typeof addCategoryButton> = {
  title: "components/addCategoryButton",
  component: addCategoryButton,
  render: (args) => ({
    components: { addCategoryButton },
    tags: ["autodocs"],
    setup() {
      return { args };
    },
    template: '<addCategoryButton v-bind="args" />',
    parameters: { actions: { argTypesRegex: "^on.*" } }
  })
};

export default meta;

export const Default = {};
