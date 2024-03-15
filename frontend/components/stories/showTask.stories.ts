import type { Meta, StoryObj } from "@storybook/vue3";
import showTask from "../showTask.vue";

const meta: Meta<typeof showTask> = {
  title: "components/showTask",
  component: showTask,
  render: (args) => ({
    components: { showTask },
    tags: ["autodocs"],
    setup() {
      return { args };
    },
    template: '<showTask v-bind="args" />',
    parameters: { actions: { argTypesRegex: "^on.*" } }
  })
};

export default meta;

export const Default = {};
export const Pattern1: StoryObj = {
  args: {
    tasks: [
      {
        category: "Work",
        task: "sample1",
        ischeck: true
      },
      {
        category: "Life",
        task: "sample2",
        ischeck: false
      }
    ]
  }
};
