import type { Meta, StoryObj } from "@storybook/vue3";
import addTask from "../addTask.vue";

const meta: Meta<typeof addTask> = {
  title: "components/addTask",
  component: addTask,
  render: (args) => ({
    components: { addTask },
    tags: ["autodocs"],
    setup() {
      return { args };
    },
    template: '<addTask v-bind="args" />',
    parameters: { actions: { argTypesRegex: "^on.*" } }
  })
};

export default meta;

export const Default = {};
export const Pattern1: StoryObj = {
  args: {
    category: "Work"
  }
};
